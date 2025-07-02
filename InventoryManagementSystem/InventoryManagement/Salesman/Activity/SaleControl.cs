using InventoryManagement.Generator;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;



namespace InventoryManagement.Salesman.Activity
{
    public partial class SaleControl : UserControl
    {
        private Database.DataAccess Da { get; set; }
        private Generator.IdGenerator IdGen { get; set; }
        private string Query { get; set; }

        private List<CartItem> CartItems = new List<CartItem>();

        private FormSalesmanHome FormSalesmanHomeRef { get; set; }
        private string SalesmanId { get; set; }
        public SaleControl(FormSalesmanHome form, string sID)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.IdGen = new IdGenerator();
            this.lblInvoiceNo.Text = IdGen.GenerateInvoiceNo();
            this.SalesmanId = sID;

            this.Query = @"SELECT  
                            p.P_ID,
                            p.P_Name,
                            p.P_Image,
                            FORMAT(p.P_SellingPrice, 'N2') AS P_SellingPrice,
                            p.P_StockQuantity,
                            d.Discount_Type,
                            CASE
                                WHEN d.Discount_Type = 'Fixed' THEN CONCAT(FORMAT(d.Discount_value, 'N2'), ' Tk')
                                WHEN d.Discount_Type = 'Percentage' THEN CONCAT(FORMAT(d.Discount_value, 'N2'), ' %')
		                        ELSE 'N/A'
                            END AS Discount
                        FROM Product p
                        LEFT JOIN ProductDiscount pd ON p.P_ID = pd.P_ID
                        LEFT JOIN Discount d ON pd.Discount_ID = d.Discount_ID;";
            this.PopulateGridView();
        }

        internal void PopulateGridView(SqlParameter[] parameter = null, string sql = null)
        {
            if (string.IsNullOrEmpty(sql))
                sql = this.Query;

            try
            {
                DataSet ds = (parameter == null)
                    ? Da.ExecuteQuery(sql)
                    : Da.ExecuteQuery(sql, parameter);

                dgvProduct.EnableHeadersVisualStyles = false;
                dgvProduct.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvProduct.ColumnHeadersDefaultCellStyle.BackColor;
                dgvProduct.AutoGenerateColumns = false;

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvProduct.DataSource = ds.Tables[0];
                    this.lblProductStatus.Visible = false;
                }
                else
                {
                    dgvProduct.DataSource = null;
                    this.lblProductStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product data. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateCartGrid()
        {
            // Store previously selected row index
            int selectedIndex = dgvCart.CurrentRow?.Index ?? -1;

            dgvCart.Rows.Clear();
            dgvCart.MultiSelect = false;

            foreach (var item in CartItems)
            {
                dgvCart.Rows.Add(item.ProductID, item.ProductName, item.Quantity, item.MRP, item.Cost.ToString("F2"));
            }

            UpdateTotals();

            // Restore selection ONLY if the row exists
            if (selectedIndex >= 0 && selectedIndex < dgvCart.Rows.Count)
            {
                dgvCart.ClearSelection();
                dgvCart.Rows[selectedIndex].Selected = true;

                //  Set CurrentCell to a visible cell only
                foreach (DataGridViewCell cell in dgvCart.Rows[selectedIndex].Cells)
                {
                    if (cell.Visible)
                    {
                        dgvCart.CurrentCell = cell;
                        break;
                    }
                }
            }
        }



        private void UpdateTotals()
        {
            decimal subtotal = CartItems.Sum(i => i.Cost);
            decimal discount = CartItems.Sum(i => i.DiscountAmount);
            decimal grandTotal = subtotal - discount;

            lblSubTotal.Text = subtotal.ToString("N0");
            lblDiscountAmount.Text = discount.ToString("N0");
            lblGrandTotal.Text = grandTotal.ToString("N0");

            if (decimal.TryParse(txtRecieveAmount.Text.Replace(",", ""), out decimal paid))
            {
                decimal returned = (paid - grandTotal >= 0) ? paid - grandTotal : 0;
                txtReturnAmount.Text = returned.ToString("N0");
            }
            else
            {
                txtReturnAmount.Text = "0.00";
            }
        }



        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProduct.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {

                
                
                // Get discount and Type
                decimal discount = 0;
                var tempDiscount = dgvProduct.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                string discountType = dgvProduct.Rows[e.RowIndex].Cells["DiscountType"].Value.ToString();
                if (tempDiscount == "N/A")
                {
                    discount = 0;
                    discountType = null;
                }
                if (discountType == "Fixed")
                {
                    tempDiscount = tempDiscount.Replace(" tk", "");
                    decimal.TryParse(tempDiscount, out discount);
                }
                else if (discountType == "Percentage")
                {
                    tempDiscount = tempDiscount.Replace(" %", "");
                    decimal.TryParse(tempDiscount, out discount);
                }

                string productId = dgvProduct.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                string productName = dgvProduct.Rows[e.RowIndex].Cells["Product"].Value.ToString();
                decimal productPrice = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["UnitPrice"].Value);
                int stockQty = GetStockByProductId(productId);

                var existing = CartItems.FirstOrDefault(ci => ci.ProductID == productId);
                if (existing != null)
                {
                    if (existing.Quantity < stockQty)
                        existing.Quantity++;
                    else
                        MessageBox.Show("Cannot add more. Stock limit reached.");
                }
                else
                {
                    if(stockQty > 0)
                    {
                        CartItems.Add(new CartItem { ProductID = productId, ProductName = productName, Quantity = 1, MRP = productPrice, Discount = discount, DiscountType = discountType});
                       
                    }
                    else
                    {
                        MessageBox.Show("Cannot add to cart. Stock is empty.");
                        return;
                    }

                }

                PopulateCartGrid();
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();
            if (rowIndex < 0) return;

            string productId = dgvCart.Rows[rowIndex].Cells["ProductID"].Value.ToString();
            var item = CartItems.FirstOrDefault(i => i.ProductID == productId);
            if (item == null) return;

            int stock = GetStockByProductId(productId);
            if (item.Quantity >= stock)
            {
                MessageBox.Show("Stock limit reached.");
                return;
            }

            item.Quantity++;
            this.txtTempQTY.Text = item.Quantity.ToString();
            PopulateCartGrid();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            int rowIndex = GetSelectedRowIndex();
            if (rowIndex < 0) return;

            string productId = dgvCart.Rows[rowIndex].Cells["ProductID"].Value.ToString();
            var item = CartItems.FirstOrDefault(i => i.ProductID == productId);
            if (item == null) return;

            if (item.Quantity > 1)
            {
                item.Quantity--;
                this.txtTempQTY.Text = item.Quantity.ToString();
            }
            else
            {
                CartItems.Remove(item);
            }

            PopulateCartGrid();
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pnlTrigger.Visible = true;
                string qty = dgvCart.Rows[e.RowIndex].Cells["Qty"].Value?.ToString() ?? "0";
                txtTempQTY.Text = qty;

                int.TryParse(qty, out int q);
                btnDecrement.Enabled = q > 0;
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "BtnCancel")
            {
                DialogResult result = MessageBox.Show("Are you sure to remove this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string productId = dgvCart.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                    CartItems.RemoveAll(i => i.ProductID == productId);
                    PopulateCartGrid();
                }
            }
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            CartItems.Clear();
            PopulateCartGrid();
            this.lblInvoiceNo.Text = IdGen.GenerateInvoiceNo();
            this.txtRecieveAmount.Text = "";
            this.txtReturnAmount.Text = "";
            this.pnlTrigger.Visible = false;
        }

        private void txtRecieveAmount_TextChanged(object sender, EventArgs e)
        {
            string rawText = txtRecieveAmount.Text.Replace(",", "").Trim();

            if (decimal.TryParse(rawText, out decimal amount))
            {
                txtRecieveAmount.TextChanged -= txtRecieveAmount_TextChanged;
                txtRecieveAmount.Text = string.Format("{0:N0}", amount);
                txtRecieveAmount.SelectionStart = txtRecieveAmount.Text.Length;
                txtRecieveAmount.TextChanged += txtRecieveAmount_TextChanged;
            }

            if (decimal.TryParse(lblGrandTotal.Text.Replace(",", ""), out decimal grandTotal) &&
                decimal.TryParse(txtRecieveAmount.Text.Replace(",", ""), out decimal receivedAmount))
            {
                if (grandTotal > receivedAmount)
                {
                    txtRecieveAmount.Focus();
                    txtRecieveAmount.FocusedState.BorderColor = Color.Red;
                }
                else
                {
                    txtRecieveAmount.FocusedState.BorderColor = Color.Green;
                }
            }

            UpdateTotals();
        }

        private int GetStockByProductId(string productId)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells["Code"].Value.ToString() == productId)
                {
                    int.TryParse(row.Cells["Quantity"].Value.ToString(), out int stock);
                    return stock;
                }
            }
            return 0;
        }

        private int GetSelectedRowIndex()
        {
            return dgvCart.CurrentRow?.Index ?? -1;
        }

        private bool IsValidToPrint()
        {
            if (CartItems.Count == 0)
            {
                MessageBox.Show("No items in the cart to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRecieveAmount.Text) || !decimal.TryParse(txtRecieveAmount.Text.Replace(",", ""), out _))
            {
                MessageBox.Show("Please enter a valid amount received.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (decimal.TryParse(txtReturnAmount.Text.Replace(",", ""), out decimal returned) && returned < 0)
            {
                MessageBox.Show("Received amount cannot be less than total cost.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(this.lblGrandTotal.Text.Replace(",", ""), out decimal grandTotal) ||
                !decimal.TryParse(this.txtRecieveAmount.Text.Replace(",", ""), out decimal receiveAmount))
            {
                MessageBox.Show("Invalid amount entered. Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRecieveAmount.Focus();
                txtRecieveAmount.FocusedState.BorderColor = Color.Red;
                return false;
            }

            if (grandTotal > receiveAmount)
            {
                txtRecieveAmount.Focus();
                txtRecieveAmount.FocusedState.BorderColor = Color.Red;
                return false;
            }
            else
            {
                txtRecieveAmount.FocusedState.BorderColor = Color.Green;
            }

            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!IsValidToPrint()) return;
            string invoiceNo = this.lblInvoiceNo.Text;
            string salesmanId = this.SalesmanId;
            SqlTransaction transaction = null;
            try
            {
                transaction = Da.SqlConn.BeginTransaction();

                // 1. Insert into Bill
                string insertBill = @"INSERT INTO Bill Values(@InvoiceNo, GETDATE(), @receivedAmount, @returnedAmount, @totalDiscount);";
                SqlParameter[] billParams = new SqlParameter[]
                {
                    new SqlParameter("@InvoiceNo", invoiceNo),
                    new SqlParameter("@receivedAmount", this.txtRecieveAmount.Text),
                    new SqlParameter("@returnedAmount", this.txtReturnAmount.Text),
                    new SqlParameter("@totalDiscount", this.lblDiscountAmount.Text)
                };
                Da.ExecuteDMLQuery(insertBill, billParams, transaction);

                foreach (var item in CartItems)
                { 
                    string saleId = this.IdGen.GenerateSaleId();

                    // 2. Insert into Sale
                    string insertSale = @"INSERT INTO Sale Values(@saleId, @saleUnitPrice, @saleQuantity, @saleSubtotal);";
                    SqlParameter[] saleParams = new SqlParameter[]
                    {
                        new SqlParameter("@saleId", saleId),
                        new SqlParameter("@saleUnitPrice", item.MRP),
                        new SqlParameter("@saleQuantity", item.Quantity),
                        new SqlParameter("@saleSubtotal", item.Cost)
                    };
                    Da.ExecuteDMLQuery(insertSale, saleParams, transaction);    


                    // 3. Insert into ProductSale
                    string insertProductSale = @"INSERT INTO ProductSale Values(@saleId, @productId);";
                    SqlParameter[] productSaleParams = new SqlParameter[]
                    {
                        new SqlParameter("@saleId", saleId),
                        new SqlParameter("@productId", item.ProductID)
                    };
                    Da.ExecuteDMLQuery(insertProductSale, productSaleParams, transaction);


                    // 4. Insert into BillSale
                    string insertBillSale = @"INSERT INTO BillSale Values(@saleId, @saleQuantity, @saleUnitPrice, @saleSubtotal, @invoiceNo);";
                    SqlParameter[] billSaleParams = new SqlParameter[]
                        {
                            new SqlParameter("@saleId", saleId),
                            new SqlParameter("@saleQuantity", item.Quantity),
                            new SqlParameter("@saleUnitPrice", item.MRP),
                            new SqlParameter("@saleSubtotal", item.Cost),
                            new SqlParameter("@invoiceNo", invoiceNo)
                        };
                    Da.ExecuteDMLQuery(insertBillSale, billSaleParams, transaction);


                    // 5. Insert into SalesmanSale
                    string insertSalesmanSale = @"INSERT INTO SalesmanSale Values(@saleId, @salesmanId);";
                    SqlParameter[] salesmanSaleParams = new SqlParameter[]
                        {
                            new SqlParameter("@saleId", saleId),
                            new SqlParameter("@salesmanId", salesmanId)
                        };
                    Da.ExecuteDMLQuery(insertSalesmanSale, salesmanSaleParams, transaction);


                    // 6.  Update stock quantity
                    string updateStock = @"UPDATE Product SET P_StockQuantity = P_StockQuantity - @qty WHERE P_ID = @pid;";
                    SqlParameter[] updateStockParams = new SqlParameter[]
                    {
                        new SqlParameter("@qty", item.Quantity),
                        new SqlParameter("@pid", item.ProductID)
                    };
                    Da.ExecuteDMLQuery(updateStock, updateStockParams, transaction);
                }

                // 6. Insert SalesmanBill
                string insertSalesmanBill = @"INSERT INTO SalesmanBill Values(@invoiceNo, @salesmanId);";
                SqlParameter[] SalesmanBillParams = new SqlParameter[]
                {
                        new SqlParameter("@invoiceNo", invoiceNo),
                        new SqlParameter("@salesmanId", salesmanId)
                };
                Da.ExecuteDMLQuery(insertSalesmanBill, SalesmanBillParams, transaction);

                transaction.Commit();

                MessageBox.Show("✅ Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // after successful commit (inside try block)
                decimal.TryParse(lblSubTotal.Text.Replace(",", ""), out decimal subTotal);
                decimal.TryParse(lblDiscountAmount.Text.Replace(",", ""), out decimal discountAmount);
                decimal.TryParse(lblGrandTotal.Text.Replace(",", ""), out decimal grandTotal);
                decimal.TryParse(txtRecieveAmount.Text.Replace(",", ""), out decimal received);
                decimal.TryParse(txtReturnAmount.Text.Replace(",", ""), out decimal returned);

                Print.SalesVoucherPrint.GenerateVoucherPDF(invoiceNo, CartItems, subTotal, discountAmount, grandTotal, received, returned);
               // GenerateThermalReceiptPDF(invoiceNo, CartItems, subTotal, discountAmount, returned);

                // Clear the cart and reset UI
                CartItems.Clear();
                PopulateCartGrid();
                this.PopulateGridView();
                this.txtRecieveAmount.Text = "";
                this.txtReturnAmount.Text = "";
                this.lblInvoiceNo.Text = IdGen.GenerateInvoiceNo();
                
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error updating stock. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var sql = @"SELECT  
                        P_ID,
                        P_Name,
                        P_Image,
                        P_SellingPrice,
                        P_StockQuantity
                    FROM Product 
                    where 
                        P_Name LIKE @searchText OR 
                        P_ID LIKE @searchText
                    ORDER BY P_ID;";

                var parameters = new System.Data.SqlClient.SqlParameter[]
                {
                new System.Data.SqlClient.SqlParameter("@searchText", "%"+ this.txtSearch.Text + "%")
                };

                PopulateGridView(parameters, sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }


    // Cart Stored the real time cart item
    public class CartItem
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal MRP { get; set; }
        public decimal Cost => Quantity * MRP;
        public decimal Discount { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountAmount
        {
            get
            {
                if (DiscountType == "Fixed")
                {
                    return Quantity * Discount;
                }
                else if (DiscountType == "Percentage")
                {
                    return Quantity * (MRP * Discount / 100);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
