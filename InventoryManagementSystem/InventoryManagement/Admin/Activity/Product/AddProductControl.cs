using Guna.UI2.WinForms;
using InventoryManagement.Admin.Activity.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace InventoryManagement.Admin.Activity
{
    //private Database.DataAccess Da { get; set; }
    public partial class AddProductControl : System.Windows.Forms.UserControl
    {
        private string ImageFilePath { get; set;}
        private FormAdminHome AdminHomeRef { get; set; }
        private Database.DataAccess Da {  get; set; }
        private string ProductCode { get; set; }
        public AddProductControl(FormAdminHome adminHome)
        {
            InitializeComponent();
            this.LoadCategory();
            this.AdminHomeRef = adminHome;
            this.Da = new Database.DataAccess();
            Generator.IdGenerator ig = new Generator.IdGenerator();
            this.ProductCode = ig.GenerateProductCode();
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            App.InputHelper.AllowDecimalOnly(sender, e);
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            App.InputHelper.AllowDecimalOnly(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation check
                if (!IsValidToAdd())
                    return;

                var result = MessageBox.Show("Are you sure to add?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                double purchasePrice;
                double sellingPrice;
                int alertQuantity;
                this.ConvertToCurrency(out purchasePrice, out sellingPrice, out alertQuantity);

                string productName = this.txtProductName.Text.Trim();
                var CatName = cmbCategory.SelectedItem.ToString().Trim();


                string query = @"
                                INSERT INTO Product 
                                VALUES (@code, @name, NULL, @purchase, @sell, 0, @alert);

                                INSERT INTO ProductCategory (P_ID, Cat_ID)
                                VALUES (@code, (SELECT Cat_ID FROM Category WHERE Cat_Name = @cat));";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@code", this.ProductCode),
                    new SqlParameter("@name", productName),
                    new SqlParameter("@purchase", purchasePrice),
                    new SqlParameter("@sell", sellingPrice),
                    new SqlParameter("@alert", alertQuantity),
                    new SqlParameter("@cat", CatName)
                };

                var count = Da.ExecuteDMLQuery(query, parameters);

                if (count == 2)
                {
                    Database.ImageManager im = new Database.ImageManager();
                    var destinationImagePath = im.SaveImageToProductFolder(this.ImageFilePath, this.txtProductName.Text);

                    string safeImagePath = destinationImagePath.Replace("'", "''");
                    string sql = "UPDATE PRODUCT SET P_Image = @image WHERE P_ID = @code;";
                    SqlParameter[] indexer = new SqlParameter[]
                    {
                        new SqlParameter("@image", safeImagePath),
                        new SqlParameter("@code", this.ProductCode)
                    };
                    var count1 = Da.ExecuteDMLQuery(sql, indexer);

                    if (count1 == 1)
                    {
                        MessageBox.Show("Product has been added to the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListProductControl lpc = new ListProductControl(this.AdminHomeRef);
                        this.AdminHomeRef.panelContainer.Controls.Clear();
                        this.AdminHomeRef.panelContainer.Controls.Add(lpc);
                        lpc.Dock = DockStyle.Fill;
                        lpc.BringToFront();

                        this.Hide();
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save product image path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Product hasn't been added to the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ConvertToCurrency(out double buyPrice, out double sellPrice, out int alert)
        {
            buyPrice = Convert.ToDouble(this.txtPurchasePrice.Text);
            sellPrice = Convert.ToDouble(this.txtSellingPrice.Text);
            alert = Convert.ToInt32(this.txtAlertQuantity.Text);
        }
        private bool IsValidToAdd()
        {
            if (string.IsNullOrWhiteSpace(this.txtProductName.Text))
            {
                MessageBox.Show("🔴 Please enter the product name.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtPurchasePrice.Text))
            {
                MessageBox.Show("🔸 Please enter the purchase price.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtSellingPrice.Text))
            {
                MessageBox.Show("🔸 Please enter the selling price.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtAlertQuantity.Text))
            {
                MessageBox.Show("⚠️ Please enter the alert quantity.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.cmbCategory.Text))
            {
                MessageBox.Show("📁 Please select a category.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.pcbProduct.Image == null)
            {
                MessageBox.Show("🖼️ Please upload/select a product image.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            this.txtProductName.Clear();
            this.txtPurchasePrice.Clear();
            this.txtSellingPrice.Clear();
            this.txtAlertQuantity.Clear();
            this.cmbCategory.SelectedIndex = -1;
            this.pcbProduct.Image = null;
        }

        private void LoadCategory()
        {
            try
            {
                var sql = "select Cat_Name  from category;";
                Database.DataAccess da = new Database.DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                cmbCategory.Items.Clear();
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
                    cmbCategory.Items.Add("No category available");
                    cmbCategory.SelectedIndex = 0;
                    cmbCategory.Enabled = false;
                    cmbCategory.ForeColor = Color.Gray;
                    cmbCategory.Font = new Font(cmbCategory.Font, FontStyle.Italic);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("❌ Failed to load categories.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string imagePath;
            Image picture;
            Database.ImageManager imageManager = new Database.ImageManager();
            if (imageManager.OpenFileExplorerProduct(out imagePath, out picture))
            {
                this.ImageFilePath = imagePath;

                this.lblFileName.Text = imagePath.Length > 20
                    ? imagePath.Substring(0, 20) + "..."
                    : imagePath;

                this.pcbProduct.Image = picture;
            }
        }

        private void txtPurchasePrice_KeyDown(object sender, KeyEventArgs e)
        {
            RestrictCurrencyInput(e, (Guna2TextBox)sender);
        }

        // Restrict Non Currency key
        private void RestrictCurrencyInput(KeyEventArgs e, Guna2TextBox tb)
        {
            // Check if it's a digit key (main keyboard or numpad)
            bool isDigit = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
                         || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);

            // Allow only one dot
            bool isDot = (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
                         && !tb.Text.Contains(".");

            // Allow: Backspace, Tab, Enter
            bool isControl = e.KeyCode == Keys.Back || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter;

            if (!(isDigit || isDot || isControl))
            {
                e.SuppressKeyPress = true;
            }
            if(e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtSellingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            RestrictCurrencyInput(e, (Guna2TextBox)sender);
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlertQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            RestrictCurrencyInput(e, (Guna2TextBox)sender);
        }
    }
}
