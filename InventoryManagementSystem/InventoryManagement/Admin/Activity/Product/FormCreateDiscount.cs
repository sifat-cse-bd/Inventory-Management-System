using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity.Product
{
    public partial class FormCreateDiscount : Form
    {
        private Database.DataAccess Da { get; set; }
        private string DiscountID { get; set; }
        private string DiscountValue { get; set; }
        private FormAdminHome AdminHomeRef { get; set; }
        public FormCreateDiscount(FormAdminHome form)
        {
            InitializeComponent();
            this.DiscountID = new Generator.IdGenerator().GenerateDiscountId();
            this.Da = new Database.DataAccess();
            this.lblDiscountID.Text += this.DiscountID;
            this.DiscountValue = null;
            this.AdminHomeRef = form;
        }

        private void FormCreateDiscount_Load(object sender, EventArgs e)
        {
            this.cmbDiscountType.SelectedIndex = 0; // Default to "Fixed"
        }

        private void RestrictDiscountInput(KeyEventArgs e, Guna2TextBox tb)
        {
            bool isDigit = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
                         || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isDot = (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) && !tb.Text.Contains(".");
            bool isControl = e.KeyCode == Keys.Back || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter;

            if (!(isDigit || isDot || isControl))
            {
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            this.RestrictDiscountInput(e, (Guna2TextBox)sender);
        }

        private void cmbDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscountType.SelectedIndex == 0)
            {
                this.lblSuffix.Text = "BDT";
            }
            else if (cmbDiscountType.SelectedIndex == 1)
            {
                this.lblSuffix.Text = "%";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.IsValidToSave())
                    return;

                string sql = @"INSERT INTO discount VALUES(@discountID, @discountValue,  @discountType);
                               INSERT INTO AdminDiscount VALUES(@discountID, @adminID);";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@discountID", this.DiscountID),
                    new SqlParameter("@discountValue", this.txtDiscount.Text.Trim()),
                    new SqlParameter("@discountType", cmbDiscountType.SelectedItem.ToString() == "Fixed Amount" ? "Fixed" : "Percentage"),
                    new SqlParameter("@adminID", this.AdminHomeRef.AdminId)
                };

                var count = Da.ExecuteDMLQuery(sql, parameters);

                if (count == 2)
                {
                    MessageBox.Show("Discount created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the discount: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool IsValidToSave()
        {
            if (cmbDiscountType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a discount type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string selectedText = cmbDiscountType.SelectedItem.ToString().Trim();
            string discountValue = txtDiscount.Text.Trim();

            if (string.IsNullOrWhiteSpace(discountValue))
            {
                MessageBox.Show("Please enter a discount value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                string sql = @"SELECT COUNT(*) AS CountValue FROM discount 
                                WHERE Discount_Value = @value 
                                AND Discount_Type = @type;";
                SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@value", discountValue),
                        new SqlParameter("@type", cmbDiscountType.SelectedItem.ToString() == "Fixed Amount" ? "Fixed" : "Percentage")
                    };

                DataTable dt = Da.ExecuteQueryTable(sql, parameters);

                int count = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    count = Convert.ToInt32(dt.Rows[0]["CountValue"]);
                }

                if (count > 0)
                {
                    MessageBox.Show($"This {discountValue} value already exists. Duplicate discounts are not allowed.", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for duplicates:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        private void txtDiscount_Leave(object sender, EventArgs e)
        {
                
        }
    }
}
