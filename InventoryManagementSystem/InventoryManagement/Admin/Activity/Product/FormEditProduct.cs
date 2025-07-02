using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity.Product
{
    public partial class FormEditProduct : Form
    {
        Database.DataAccess Da { get; set; }
        Database.ImageManager Im { get; set; }
        ListProductControl Lp { get; set; }
        private string PreviousImagePath { get; set; }
        private string CurrentImagePath { get; set; }

        public FormEditProduct(string productCode, string productName, string purchasePrice, string sellingPrice, string alertQuantity, string category, string imagePath, ListProductControl listProduct)
        {
            InitializeComponent();

            this.lblProductCode.Text = productCode;
            this.txtProductName.Text = productName;
            this.txtPurchasePrice.Text = purchasePrice;
            this.txtSellingPrice.Text = sellingPrice;
            this.txtAlertQuantity.Text = alertQuantity;
            this.PreviousImagePath = imagePath;
            this.CurrentImagePath = imagePath;
            this.Lp = listProduct;
            this.Da = new Database.DataAccess();
            this.Im = new Database.ImageManager();

            if (File.Exists(imagePath))
            {
                try
                {
                    using (var bmpTemp = new Bitmap(imagePath))
                    {
                        this.pcbProduct.Image = new Bitmap(bmpTemp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Image file not found at: " + imagePath);
            }

            this.LoadCategory();
            this.cmbCategory.SelectedItem = category;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void LoadCategory()
        {
            try
            {
                var sql = "SELECT Cat_Name FROM Category;";
                DataSet ds = Da.ExecuteQuery(sql);

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
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load categories.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            txtProductName.Clear();
            txtPurchasePrice.Clear();
            txtSellingPrice.Clear();
            txtAlertQuantity.Clear();
            cmbCategory.SelectedIndex = -1;
            pcbProduct.Image = null;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string imagePath;
            Image picture;
            this.Im.OpenFileExplorerProduct(out imagePath, out picture);

            if (picture != null)
            {
                this.pcbProduct.Image = picture;
                this.CurrentImagePath = imagePath;
            }
        }

        private void RestrictCurrencyInput(KeyEventArgs e, Guna2TextBox tb)
        {
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

        private void txtPurchasePrice_KeyDown(object sender, KeyEventArgs e) => RestrictCurrencyInput(e, (Guna2TextBox)sender);
        private void txtSellingPrice_KeyDown(object sender, KeyEventArgs e) => RestrictCurrencyInput(e, (Guna2TextBox)sender);

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToUpdate()) return;

                var result = MessageBox.Show("Are you sure to Update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                double purchasePrice;
                double sellingPrice;
                int alertQuantity;
                ConvertToCurrency(out purchasePrice, out sellingPrice, out alertQuantity);

                string productName = txtProductName.Text.Replace("'", "''");
                string catName = cmbCategory.SelectedItem.ToString().Replace("'", "''");
                string savedImagePath = PreviousImagePath;

                // Image update check
                if (PreviousImagePath != CurrentImagePath)
                {
                    if (pcbProduct.Image != null)
                    {
                        pcbProduct.Image.Dispose();
                        pcbProduct.Image = null;
                    }

                    Im.DeleteImage(PreviousImagePath);
                    savedImagePath = Im.SaveImageToProductFolder(CurrentImagePath, productName);
                }

                string safeImagePath = savedImagePath?.Replace("'", "''") ?? "";

                string sql = $@"
                    BEGIN TRANSACTION;

                    UPDATE Product
                    SET 
                        P_Name = '{productName}',
                        P_PurchasingPrice = '{purchasePrice}',
                        P_SellingPrice = '{sellingPrice}',
                        P_AlertQuantity = '{alertQuantity}',
                        P_Image = '{safeImagePath}'
                    WHERE P_ID = '{lblProductCode.Text}';

                    UPDATE ProductCategory
                    SET 
                        Cat_ID = (SELECT Cat_ID FROM Category WHERE Cat_Name = '{catName}')
                    WHERE P_ID = '{lblProductCode.Text}';

                    COMMIT;";

                int count = Da.ExecuteDMLQuery(sql);

                if (count == 2)
                {
                    MessageBox.Show("✅ Product has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lp.PopulateGridView();
                    this.Hide();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("⚠️ Product hasn't been updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertToCurrency(out double buyPrice, out double sellPrice, out int alert)
        {
            buyPrice = Convert.ToDouble(txtPurchasePrice.Text);
            sellPrice = Convert.ToDouble(txtSellingPrice.Text);
            alert = Convert.ToInt32(txtAlertQuantity.Text);
        }

        private bool IsValidToUpdate()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("🔴 Please enter the product name.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
            {
                MessageBox.Show("🔸 Please enter the purchase price.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSellingPrice.Text))
            {
                MessageBox.Show("🔸 Please enter the selling price.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAlertQuantity.Text))
            {
                MessageBox.Show("⚠️ Please enter the alert quantity.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("📁 Please select a category.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pcbProduct.Image == null)
            {
                MessageBox.Show("🖼️ Please upload/select a product image.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
