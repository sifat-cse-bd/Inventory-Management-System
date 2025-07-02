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

namespace InventoryManagement.App
{
    public partial class FormNewPasswordEntry : Form
    {
        private Database.DataAccess Da { get; set; }
        private string UserId { get; set; }
        private FormResetPassword FormResetPasswordRef { get; set; }

        public FormNewPasswordEntry(string userId, FormResetPassword form)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.FormResetPasswordRef = form;
            this.UserId = userId;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToChange()) return;

            try
            {
                var sql = "UPDATE Users SET U_Password = @newPassword WHERE U_ID = @userID;";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@newPassword", this.txtNewRePassword.Text), // or encrypt here
                    new SqlParameter("@userID", this.UserId)
                };

                var count = Da.ExecuteDMLQuery(sql, parameters);

                if (count == 1)
                {
                    MessageBox.Show($"Password Changed Successfully\n\nNew Password: {this.txtNewRePassword.Text}",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally clear fields or hide control
                    this.txtNewPassword.Clear();
                    this.txtNewRePassword.Clear();
                    this.Close();
                    this.FormResetPasswordRef.Close();
                }
                else
                {
                    MessageBox.Show("Failed to change password. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting the password:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidToChange()
        {
            if (string.IsNullOrWhiteSpace(this.txtNewPassword.Text))
            {
                MessageBox.Show("Please enter new password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtNewPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be minimun 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtNewRePassword.Text))
            {
                MessageBox.Show("Please re-enter new password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtNewPassword.Text != this.txtNewRePassword.Text)
            {
                MessageBox.Show("Re-entered password does not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
