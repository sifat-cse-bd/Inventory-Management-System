using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity.Product
{
    public partial class FormPurchase : Form
    {
        Database.DataAccess Da {  get; set; }
        ListProductControl LPC { get; set; }
        FormAdminHome AdminHomeRef { get; set; }
        public FormPurchase(string productCode, string productName, string purchasingPrice, string previousStock, ListProductControl lpc, FormAdminHome form)
        {
            InitializeComponent();
            this.lblProductCode.Text = productCode;
            this.lblProductName.Text = productName;
            this.lblStock.Text = previousStock;
            this.lblCostPrice.Text = purchasingPrice;
            this.lblPurchaseID.Text = new Generator.IdGenerator().GeneratePurchaseID();
            this.Da = new Database.DataAccess();
            this.LPC = lpc;
            this.AdminHomeRef = form;
        }

        public FormPurchase()
        {
            InitializeComponent();
        }


        private void RestrictCurrencyInput(KeyEventArgs e, Guna2TextBox tb)
        {
            // Prevent paste using Ctrl+V
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                return;
            }
            bool isDigit = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
                        || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);

            bool isDot = (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
                        && !tb.Text.Contains(".");

            bool isControl = e.KeyCode == Keys.Back || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter;

            if (!(isDigit || isDot || isControl))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            this.RestrictCurrencyInput(e, (Guna2TextBox)sender);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsInvalidZeroPattern(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

           
            if (input == "0" || System.Text.RegularExpressions.Regex.IsMatch(input, @"^0\.\d{0,2}$"))
                return false;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^0{2,}(\.\d*)?$"))
                return true;

            if (input.StartsWith("0") && input.Length > 1 && input[1] != '.')
                return true;

            return false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as Guna2TextBox;

            if (IsInvalidZeroPattern(tb.Text))
            {
                tb.Text = "";
                tb.SelectionStart = 0;
                return;
            }
            var unitPrice = Convert.ToDouble((this.lblCostPrice.Text));
            double purchaseQuantity;

            if (string.IsNullOrEmpty(this.txtQuantity.Text))
            {
                purchaseQuantity = 0.0;
            }
            else
            {
                purchaseQuantity = Convert.ToDouble(this.txtQuantity.Text);
            }
            this.lblTotal.Text = (unitPrice * purchaseQuantity).ToString("N2");
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtQuantity.Text == "0" || string.IsNullOrEmpty(this.txtQuantity.Text))
                    return;

                int GetSafeNumber(string text)
                {
                    return int.TryParse(text, out int number) ? number : 0;
                }

                int currentStock = int.Parse(txtQuantity.Text);
                int previousStock = GetSafeNumber(this.lblStock.Text.Trim());
                int newStock = currentStock + previousStock;


                string costPrice = this.lblCostPrice.Text.Trim();
                string totalPrice = this.lblTotal.Text.Trim();


                string sql = $@"
                                UPDATE Product 
                                SET P_StockQuantity = @newStock
                                WHERE P_ID = @pID;

                                INSERT INTO ProductPurchase (Purchase_ID, P_ID) 
                                VALUES (@purchaseID, @pID);

                                INSERT INTO Purchase (Purchase_ID, Purchase_Quantity, Purchase_UnitPrice, Purchase_TotalPrice, Purchase_Date) 
                                VALUES (@purchaseID, @currentStock, @costPrice, @totalPrice, GETDATE()); ";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@newStock", newStock),
                    new SqlParameter("@pID", this.lblProductCode.Text),
                    new SqlParameter("@purchaseID", this.lblPurchaseID.Text),
                    new SqlParameter("@currentStock", currentStock),
                    new SqlParameter("@costPrice", costPrice),
                    new SqlParameter("@totalPrice", totalPrice)
                };
                int count = Da.ExecuteDMLQuery(sql, parameters);

                if (count >= 3)
                {
                    MessageBox.Show("Purchased Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LPC.PopulateGridView();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Purchase failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
