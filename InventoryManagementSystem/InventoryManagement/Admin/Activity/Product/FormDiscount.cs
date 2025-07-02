using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace InventoryManagement.Admin.Activity.Product
{
    public partial class FormDiscount : Form
    {
        private Database.DataAccess Da { get; set; }
        private FormAdminHome AdminHomeRef { get; set; }
        public FormDiscount(string pCode, string pName, FormAdminHome form)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.lblProductCode.Text = pCode;
            this.lblProductName.Text = pName;
            this.AdminHomeRef = form;
        }

        private void FormDiscount_Load(object sender, EventArgs e)
        {
            this.rdFixed.Checked = true; 
            this.LoadDiscount();
            this.GetDiscountStatus();
            if (flag) btnDelete.Enabled = true;
            else btnDelete.Enabled = false;
        }

        private void LoadDiscount()
        {
            try
            {
                string type = this.rdFixed.Checked ? "Fixed" : "Percentage";

                string sql = @"SELECT 
                          Discount_ID, 
                          CAST(Discount_value AS varchar(10)) + 
                          CASE 
                            WHEN @type = 'Fixed' THEN ' tk' 
                            ELSE ' %' 
                          END AS DisplayText 
                       FROM Discount 
                       WHERE Discount_Type = @type;";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@type", type)
                };

                DataSet ds = Da.ExecuteQuery(sql, parameters);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.cmbDiscount.Enabled = true;
                    this.cmbDiscount.DataSource = ds.Tables[0];
                    this.cmbDiscount.DisplayMember = "DisplayText";
                    this.cmbDiscount.ValueMember = "Discount_ID";
                    this.cmbDiscount.SelectedIndex = 0;
                }
                else
                {
                    this.cmbDiscount.DataSource = null;
                    this.cmbDiscount.Items.Clear();
                    this.cmbDiscount.Items.Add($"No {type} Discount Available");
                    this.cmbDiscount.SelectedIndex = 0;
                    this.cmbDiscount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading discounts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void rdFixed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFixed.Checked)
                this.LoadDiscount(); 
        }

        private void rdPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPercentage.Checked)
                this.LoadDiscount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatNew_Click(object sender, EventArgs e)
        {
            new FormCreateDiscount(this.AdminHomeRef).ShowDialog();
            this.LoadDiscount(); 
        }

        private void rdPercentage_CheckedChanged_1(object sender, EventArgs e)
        {
            this.LoadDiscount();
        }

        private void rdFixed_CheckedChanged_1(object sender, EventArgs e)
        {
            this.LoadDiscount();

        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                string discountId = GetSelectedDiscountId();
                if (discountId == null)
                {
                    MessageBox.Show("Please select a valid discount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.flag)
                {
                    // Update existing discount
                    var sql = @"UPDATE ProductDiscount SET Discount_ID = @discountID WHERE p_id = @pCode;";
                    SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@pCode", lblProductCode.Text),
                        new SqlParameter("@discountID", discountId)
                    };

                    var count = Da.ExecuteDMLQuery(sql, sqlParameter);
                    if (count > 0)
                    {
                        MessageBox.Show("Discount updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.GetDiscountStatus();
                    }
                }
                else
                {
                    // Insert new discount
                    var sql = @"INSERT INTO ProductDiscount VALUES(@pCode, @discountID);";
                    SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@pCode", lblProductCode.Text),
                        new SqlParameter("@discountID", discountId)
                    };

                    var count = Da.ExecuteDMLQuery(sql, sqlParameter);
                    if (count > 0)
                    {
                        MessageBox.Show("Discount added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.GetDiscountStatus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding/updating discount:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private bool flag = false;
        private void GetDiscountStatus()
        {
            try
            {
                var sql = @"SELECT * FROM ProductDiscount pd
                    JOIN Discount d ON pd.Discount_ID = d.Discount_ID
                    WHERE p_id = @pCode;";

                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@pCode", lblProductCode.Text)
                };

                var ds = Da.ExecuteQuery(sql, sqlParameter);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string existing = ds.Tables[0].Rows[0]["Discount_Value"].ToString();
                    string type = ds.Tables[0].Rows[0]["Discount_Type"].ToString();

                    if (type == "Fixed")
                    {
                        lblDiscountStatus.Text = "This product already has a discount of ৳" + existing;
                    }
                    else
                    {
                        lblDiscountStatus.Text = "This product already has a discount of " + existing + "%";
                    }
                    flag = true;
                }
                else
                {
                    lblDiscountStatus.Text = "No discount available for this product.";
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred while checking discount status:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                try
                {
                    var sql = @"DELETE FROM ProductDiscount 
                        WHERE p_id = @pCode;";

                    SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@pCode", lblProductCode.Text)
                    };

                    var count = Da.ExecuteDMLQuery(sql, sqlParameter);

                    if (count > 0)
                    {
                        MessageBox.Show("Discount successfully removed for this product.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.flag = false;
                        this.cmbDiscount.DataSource = null;
                        this.cmbDiscount.Items.Clear();
                        this.cmbDiscount.Items.Add("Select Discount");
                        this.cmbDiscount.SelectedIndex = 0;
                        this.cmbDiscount.Enabled = false;

                        lblDiscountStatus.Text = "No discount available for this product.";
                    }
                    else
                    {
                        MessageBox.Show("No discount found for this product to delete.",
                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting discount:\n" + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSelectedDiscountId()
        {
            try
            {
                if (cmbDiscount.SelectedItem == null || !cmbDiscount.Enabled || cmbDiscount.SelectedValue == null)
                {
                    MessageBox.Show("No discount selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                return cmbDiscount.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving Discount ID:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
