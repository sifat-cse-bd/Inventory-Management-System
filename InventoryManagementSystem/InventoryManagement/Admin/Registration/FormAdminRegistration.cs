using InventoryManagement.Admin.Registration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventoryManagement.Admin
{
    public partial class FormAdminRegistration : Form
    {
        private App.FormLogin FormLoginRef { get; set; }
        private string ImageFilePath { get; set; }
        private Database.DataAccess Da { get; set; }
        private DateTime defaultDob;
        public FormAdminRegistration(App.FormLogin form)
        {
            InitializeComponent();
            this.Da  = new Database.DataAccess();
            this.FormLoginRef = form;
        }

        private void FromAdminRegistration_Load(object sender, EventArgs e)
        {
            this.defaultDob = new DateTime(2000, 1, 1);
            this.dtpDOB.Value = defaultDob;
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private bool IsRegisteredEmail(string email)
        {
            try
            {
                var sql = "SELECT COUNT(*) AS EmailCount FROM USERS WHERE U_Email = @email;";
                SqlParameter[] parameters = { new SqlParameter("@email", email) };

                var ds = this.Da.ExecuteQuery(sql, parameters);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int count = Convert.ToInt32(ds.Tables[0].Rows[0]["EmailCount"]);
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            lblEmailFormatWarning.Visible = false;

            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                this.lblEmailFormatWarning.Text = "Email field cannot be empty!";
                this.lblEmailFormatWarning.ForeColor = Color.Gray;
                this.lblEmailFormatWarning.Visible = true;
                this.txtEmail.Focus();
                return;
            }
            if(!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                this.lblEmailFormatWarning.Text = "Invalid Email Format";
                this.lblEmailFormatWarning.ForeColor = Color.Red;
                this.lblEmailFormatWarning.Visible = true;
                this.txtEmail.Focus();
                return;
            }

            if (this.IsRegisteredEmail(this.txtEmail.Text) == true)
            {
                MessageBox.Show("This email is already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
        }
       
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            this.lblPhoneFormat.Visible = false;
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                this.lblPhoneFormat.Text = "Phone field cannot be empty!";
                this.lblPhoneFormat.ForeColor = Color.Gray;
                this.lblPhoneFormat.Visible = true;
                //this.txtPhone.Focus();
                return;
            }
            if (!Regex.IsMatch(phone, @"^01[0-9]{9}$"))
            {
                this.lblPhoneFormat.Text = "Invalid contact number format.";
                this.lblPhoneFormat.ForeColor = Color.Red;
                this.lblPhoneFormat.Visible = true;
                this.txtPhone.Focus();
                return;
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Max 11 digits
            if (txtPhone.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToPreview())
                return;

            FormPreviewReg previewReg = new FormPreviewReg(
                this.pictureBoxProfile.Image,
                this.ImageFilePath,
                this.txtName.Text.Trim(),
                this.txtEmail.Text.Trim(),
                this.txtPhone.Text.Trim(),
                this.dtpDOB.Value,
                this.txtPassword.Text.Trim(),
                this.FormLoginRef,
                this
            );

            previewReg.Show();
            this.Hide();
        }
        private bool IsValidToPreview()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password field is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pictureBoxProfile.Image == null)
            {
                MessageBox.Show("Please upload a profile picture!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpDOB.Value.Date == defaultDob.Date)
            {
                var result = MessageBox.Show("Is it your valid Date Of Birth!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.No)
                return false;
            }
            return true;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            string imagePath;
            Image picture;
            Database.ImageManager imageManager = new Database.ImageManager();
            if (imageManager.OpenFileExplorer(out imagePath, out picture))
            {
                this.ImageFilePath = imagePath;

                this.lblImageFileName.Text = imagePath.Length > 20
                    ? imagePath.Substring(0, 20) + "..."
                    : imagePath;

                this.pictureBoxProfile.Image = picture;
            }
        }
            
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.FormLoginRef.Show(); 
            this.Hide();
        }


        private void chkPasswordVisiblity_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPasswordVisiblity.Checked;
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length > 14)
            {
                MessageBox.Show("Password cannot be more than 14 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.FormLoginRef.Show(); //back to home form
            this.Hide();
        }
    }
}
