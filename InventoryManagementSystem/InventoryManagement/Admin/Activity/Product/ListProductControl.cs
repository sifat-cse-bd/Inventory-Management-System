using InventoryManagement.Admin.Activity.Product;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InventoryManagement.Admin.Activity
{
    public partial class ListProductControl : UserControl
    {
        Database.DataAccess Da {  get; set; } 
        string Query { get; set; }
        FormAdminHome AdminHomeRef { get; set; }
        public ListProductControl(FormAdminHome form)
        {
            InitializeComponent();
            this.AdminHomeRef = form;
            this.Da = new Database.DataAccess();
            this.LoadCategory();
            

            this.Query = @"SELECT  
                                p.P_ID, p.P_Name, p.P_Image, 
                                Concat(p.P_PurchasingPrice, ' tk') as P_PurchasingPrice,
                                Concat(p.P_SellingPrice, ' tk') as P_SellingPrice,
                                CASE
                                    when p.P_StockQuantity = 0 then 'Stock Out'
                                    else Convert(varchar, p.P_StockQuantity)
                                End as P_StockQuantity, p.P_AlertQuantity,
                                ISNULL(c.Cat_Name, 'N/A') as Categories,
                                CASE 
                                    WHEN d.Discount_Value Is null then 'N/A'
                                    WHEN d.Discount_Type = 'Fixed' THEN Concat(Convert(Varchar, d.Discount_Value), ' tk')
                                    WHEN d.Discount_Type = 'Percentage' THEN Concat(Convert(Varchar, d.Discount_Value), ' %')    
                                    ELSE Convert(varchar, d.Discount_Value)
                                END AS Discount_Value,
                                ISNULL(d.Discount_Type, 'N/A') AS Discount_Type 
                            FROM PRODUCT p
                                Left join productCategory pc on p.P_ID = pc.P_ID
                                Left join category c on pc.Cat_ID = c.Cat_ID
                                Left join productDiscount pd on p.P_ID = pd.P_ID
                                Left Join discount d on pd.Discount_ID = d.Discount_ID;";
            
            this.cmbFilter.SelectedIndex = 0; 
            this.isFilterLoaded = true;
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

                dgvProductList.EnableHeadersVisualStyles = false;
                dgvProductList.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvProductList.ColumnHeadersDefaultCellStyle.BackColor;
                dgvProductList.AutoGenerateColumns = false;

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvProductList.DataSource = ds.Tables[0];
                    this.lblProductStatus.Visible = false;
                }
                else
                {
                    dgvProductList.DataSource = null;
                    this.lblProductStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product data. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DeleteProduct()
        {
            try
            {
                if (dgvProductList.CurrentRow == null || dgvProductList.CurrentRow.Index < 0)
                {
                    MessageBox.Show("No product to delete.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var pCode = dgvProductList.SelectedRows[0].Cells["ProductCode"].Value.ToString();
                var product = dgvProductList.SelectedRows[0].Cells["Product"].Value.ToString();
                var imagePath = dgvProductList.SelectedRows[0].Cells["Photo"].Value?.ToString();
                var selectedRows = dgvProductList.SelectedRows.Count;

                string query = @"DELETE FROM ProductCategory WHERE P_ID = @pCode;
                         DELETE FROM Product WHERE P_ID = @pCode;";

                SqlParameter[] parameter = new SqlParameter[] 
                {
                                new SqlParameter("@pCode", pCode)
                };

                var count = Da.ExecuteDMLQuery(query, parameter);

                if (count == (selectedRows * 2))
                {
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        Database.ImageManager imageManager = new Database.ImageManager();
                        imageManager.DeleteImage(imagePath);
                    }

                    MessageBox.Show(product.ToUpper() + " has been deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(product.ToUpper() + " has not been deleted from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unwanted Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.PopulateGridView();
        }



        private void EditProduct()
        {
            try
            {
                if (this.dgvProductList.CurrentRow == null || this.dgvProductList.CurrentRow.Index < 0)
                {
                    MessageBox.Show($"No product to update.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var pCode = this.dgvProductList.SelectedRows[0].Cells["ProductCode"].Value.ToString();
                var pName = this.dgvProductList.SelectedRows[0].Cells["Product"].Value.ToString();
                var pPurchasingPrice = this.dgvProductList.SelectedRows[0].Cells["PurchasingPrice"].Value.ToString().Split(' ')[0].Trim();
                var pSellingPrice = this.dgvProductList.SelectedRows[0].Cells["SellingPrice"].Value.ToString().Split(' ')[0].Trim();
                var pAlertQuantity = this.dgvProductList.SelectedRows[0].Cells["AlertQuantity"].Value.ToString();
                var pImagePath = this.dgvProductList.SelectedRows[0].Cells["Photo"].Value.ToString();
                var pCategory = this.dgvProductList.SelectedRows[0].Cells["Category"].Value.ToString();

                FormEditProduct pEdit = new FormEditProduct(pCode, pName, pPurchasingPrice, pSellingPrice, pAlertQuantity, pCategory, pImagePath, this);
                pEdit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductList.Columns[e.ColumnIndex].Name == "Photo")
            {
                string path = e.Value?.ToString();
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        using (var tempImage = Image.FromStream(fs))
                        {
                            e.Value = new Bitmap(tempImage);
                        }
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeleteProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteProduct();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EditProduct();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.EditProduct();
        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            dgvProductList.Columns[0].Visible = true; 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = @"SELECT  
                                p.P_ID, p.P_Name, p.P_Image, 
                                Concat(p.P_PurchasingPrice, ' tk') as P_PurchasingPrice,
                                Concat(p.P_SellingPrice, ' tk') as P_SellingPrice,
                                CASE
                                    when p.P_StockQuantity = 0 then 'Stock Out'
                                    else Convert(varchar, p.P_StockQuantity)
                                End as P_StockQuantity, p.P_AlertQuantity,
                                ISNULL(c.Cat_Name, 'N/A') as Categories,
                                CASE 
                                    WHEN d.Discount_Value Is null then 'N/A'
                                    WHEN d.Discount_Type = 'Fixed' THEN Concat(Convert(Varchar, d.Discount_Value), ' tk')
                                    WHEN d.Discount_Type = 'Percentage' THEN Concat(Convert(Varchar, d.Discount_Value), ' %')    
                                    ELSE Convert(varchar, d.Discount_Value)
                                END AS Discount_Value,
                                ISNULL(d.Discount_Type, 'N/A') AS Discount_Type 
                            FROM PRODUCT p
                                Left join productCategory pc on p.P_ID = pc.P_ID
                                Left join category c on pc.Cat_ID = c.Cat_ID
                                Left join productDiscount pd on p.P_ID = pd.P_ID
                                Left Join discount d on pd.Discount_ID = d.Discount_ID
                                WHERE p.P_Name LIKE @searchText OR p.P_ID LIKE @searchText
                                ORDER BY p.P_ID;";
            var parameters = new System.Data.SqlClient.SqlParameter[]
            {
                new System.Data.SqlClient.SqlParameter("@searchText", "%"+ this.txtSearch.Text + "%")
            };

            PopulateGridView(parameters, sql);

        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int buttonColumnIndex = 9;

            if (e.RowIndex >= 0 && e.ColumnIndex == buttonColumnIndex)
            {
                var pCode = dgvProductList.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
                var pName = dgvProductList.Rows[e.RowIndex].Cells["Product"].Value.ToString();
                var pStock = dgvProductList.Rows[e.RowIndex].Cells["StockQuantity"].Value.ToString();
                var pPrice = dgvProductList.Rows[e.RowIndex].Cells["PurchasingPrice"].Value.ToString().Split(' ')[0];

                FormPurchase formPurchase = new FormPurchase(pCode, pName, pPrice, pStock, this, this.AdminHomeRef);
                formPurchase.ShowDialog();
            }
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            string pCode = dgvProductList.SelectedRows[0].Cells["ProductCode"].Value.ToString();
            string pName = dgvProductList.SelectedRows[0].Cells["Product"].Value.ToString();
            FormDiscount formDiscount = new FormDiscount(pCode, pName, AdminHomeRef);
            formDiscount.ShowDialog();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.pnlModify.Visible = true;
        }

        bool isCategoryLoaded = false;

        private void LoadCategory()
        {
            try
            {
                isCategoryLoaded = false;

                var sql = "SELECT Cat_Name FROM category;";
                DataSet ds = Da.ExecuteQuery(sql);

                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("All");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        cmbCategory.Items.Add(row["Cat_Name"].ToString());
                    }

                    cmbCategory.Enabled = true;
                    cmbCategory.ForeColor = SystemColors.WindowText;
                    cmbCategory.Font = new Font(cmbCategory.Font, FontStyle.Regular);
                }
                else
                {
                    cmbCategory.Enabled = false;
                    cmbCategory.ForeColor = Color.Gray;
                    cmbCategory.Font = new Font(cmbCategory.Font, FontStyle.Italic);
                }

                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load categories.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isCategoryLoaded = true;
            }
        }



        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isCategoryLoaded)
                return;

            try
            {
                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("⚠️ Please select a category.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selected = cmbCategory.SelectedItem.ToString();

                if (selected == "All")
                {
                    this.PopulateGridView();
                    return;
                }

                string sql = @"SELECT  
                            p.P_ID, p.P_Name, p.P_Image, 
                            Concat(p.P_PurchasingPrice, ' tk') as P_PurchasingPrice,
                            Concat(p.P_SellingPrice, ' tk') as P_SellingPrice,
                            CASE
                                when p.P_StockQuantity = 0 then 'Stock Out'
                                else Convert(varchar, p.P_StockQuantity)
                            End as P_StockQuantity, p.P_AlertQuantity,
                            ISNULL(c.Cat_Name, 'N/A') as Categories,
                            CASE 
                                WHEN d.Discount_Value Is null then 'N/A'
                                WHEN d.Discount_Type = 'Fixed' THEN Concat(Convert(Varchar, d.Discount_Value), ' tk')
                                WHEN d.Discount_Type = 'Percentage' THEN Concat(Convert(Varchar, d.Discount_Value), ' %')    
                                ELSE Convert(varchar, d.Discount_Value)
                            END AS Discount_Value,
                            ISNULL(d.Discount_Type, 'N/A') AS Discount_Type 
                        FROM PRODUCT p
                            LEFT JOIN productCategory pc ON p.P_ID = pc.P_ID
                            LEFT JOIN category c ON pc.Cat_ID = c.Cat_ID
                            LEFT JOIN productDiscount pd ON p.P_ID = pd.P_ID
                            LEFT JOIN discount d ON pd.Discount_ID = d.Discount_ID
                        WHERE c.Cat_Name = @selectedCategory;";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@selectedCategory", selected)
                };

                this.PopulateGridView(parameters, sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error while changing category.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isFilterLoaded = false;
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isFilterLoaded)
                {
                    return;
                }

                string filter = cmbFilter.SelectedItem.ToString();
                if (string.IsNullOrEmpty(this.Query))
                {
                    MessageBox.Show("⚠️ Query is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string filteredQuery = this.Query.TrimEnd(';');

                switch (filter)
                {
                    case "All":
                        filteredQuery = this.Query;
                        break;
                    case "Stock In":
                        filteredQuery += " WHERE p.P_StockQuantity > 0";
                        break;
                    case "Stock Out":
                        filteredQuery += " WHERE p.P_StockQuantity = 0";
                        break;
                    case "Low Stock":
                        filteredQuery += " WHERE p.P_StockQuantity < p.P_AlertQuantity";
                        break;
                    case "High Stock":
                        filteredQuery += " WHERE p.P_StockQuantity >= 100";
                        break;
                    case "Discounted":
                        filteredQuery += " WHERE d.Discount_Value IS NOT NULL";
                        break;
                    case "No Discount":
                        filteredQuery += " WHERE d.Discount_Value IS NULL";
                        break;
                    default:
                        MessageBox.Show("Unknown filter selected.", "Invalid Filter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                filteredQuery += ";";

                this.PopulateGridView(null, filteredQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in filter selection:\n" + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
