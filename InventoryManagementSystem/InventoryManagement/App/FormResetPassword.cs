using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventoryManagement.App
{
    public partial class FormResetPassword : Form
    {
        private Database.DataAccess Da;
        private string ExistingEmail { get; set; }
        //private FormLogin FormLoginRef {  get; set; }

        public FormResetPassword(FormLogin form)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            //this.FormLoginRef = form;
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            this.CheckExistingUser();
        }

        private void CheckExistingUser()
        {
            try
            {
                var inputId = this.txtUserID.Text.Trim();

                if (string.IsNullOrWhiteSpace(inputId))
                {
                    this.lblUserStatus.Text = "Please enter User ID";
                    this.lblUserStatus.ForeColor = Color.Orange;
                    return;
                }

                var sql = "SELECT * FROM Users WHERE U_ID = @uid;";
                SqlParameter[] param = { new SqlParameter("@uid", inputId) };
                var dt = Da.ExecuteQueryTable(sql, param);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // User exists
                    this.ExistingEmail = dt.Rows[0]["U_Email"].ToString();

                    this.lblUserStatus.Text = "Valid User";
                    this.lblUserStatus.ForeColor = Color.Green;
                }
                else
                {
                    // No user found
                    this.lblUserStatus.Text = "Invalid User";
                    this.lblUserStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking user: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            var inputEmail = this.txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputEmail))
            {
                this.lblEmailStatus.Text = "Please enter User Email";
                this.lblEmailStatus.ForeColor = Color.Orange;
                return;
            }
            if(this.ExistingEmail == this.txtEmail.Text)
            {
                // valid email
                this.lblEmailStatus.Text = "Valid Email";
                this.lblEmailStatus.ForeColor = Color.Green;
            }
            else 
            {
                // Invalid email
                this.lblEmailStatus.Text = "Invalid Email";
                this.lblEmailStatus.ForeColor = Color.Red;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(this.lblEmailStatus.Text == "Valid Email" && this.lblUserStatus.Text == "Valid User")
            {
                new FormNewPasswordEntry(this.txtUserID.Text, this).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter valid information.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
