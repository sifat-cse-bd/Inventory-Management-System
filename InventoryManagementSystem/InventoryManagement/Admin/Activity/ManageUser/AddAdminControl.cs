using InventoryManagement.Admin.Activity.ManageUser;
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

namespace InventoryManagement.Admin.Activity
{
    public partial class AddAdminControl : UserControl
    {
        private string ImageFilePath { get; set; }
        private Database.DataAccess Da { get; set; }
        private string UserID { get; set; } // admin id
        private string Role { get; set; }
        private String TempPassword { get; set; }
        private FormAdminHome FormAdminHomeRef { get; set; }
        public AddAdminControl(FormAdminHome form)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this. UserID = new Generator.IdGenerator().GenerateAdminId();
            this.txtUserID.Text = this.UserID;
            this.Role = "Admin";
            this.TempPassword = TempUserPassword();
            this.FormAdminHomeRef = form;

        }


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.FormAdminHomeRef.panelContainer.Controls.Clear();
            this.FormAdminHomeRef.panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private string TempUserPassword()
        {
            string temp;

            if (!string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                temp = txtName.Text.Split(' ')[0];
            }
            else
            {
                temp = "admin";
            }
             return temp + DateTime.Now.ToString("HHmmss");
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.IsValidToNext())
                return;

            try
            {
                Database.ImageManager im = new Database.ImageManager();

                string destinationImagePath = im.SaveImageToUserFolder(this.ImageFilePath, this.txtName.Text);
                string sql = @"INSERT INTO users VALUES(@userId, @userPassword, @userName, @role, @email, @phone, @savedImagePath, GetDate());
                               INSERT INTO admin VALUES(@userId, @dob);";
                SqlParameter[] userParams = new SqlParameter[]
                {
                    new SqlParameter("@userId", this.UserID),
                    new SqlParameter("@userPassword", this.TempPassword),
                    new SqlParameter("@userName", this.txtName.Text),
                    new SqlParameter("@role", this.Role),
                    new SqlParameter("@email", this.txtEmail.Text),
                    new SqlParameter("@phone", this.txtPhone.Text),
                    new SqlParameter("@savedImagePath", destinationImagePath),
                    new SqlParameter("@dob", this.dtpDOB.Value)
                };

                var count = this.Da.ExecuteDMLQuery(sql, userParams);

                if (count != 2) 
                {

                    MessageBox.Show("Error saving admin registration. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }

                MessageBox.Show("Admin registration successful! Temporary password: " + this.TempPassword, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ViewUserControl viewUserControl = new ViewUserControl(this.FormAdminHomeRef);
                this.AddUserControl(viewUserControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsValidToNext()
        {
            if(string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("Email cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(this.txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return false;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imagePath;
            Image picture;
            Database.ImageManager imageManager = new Database.ImageManager();
            if (imageManager.OpenFileExplorer(out imagePath, out picture))
            {
                this.ImageFilePath = imagePath;

                this.lblSourceImagePath.Text = imagePath.Length > 20
                    ? imagePath.Substring(0, 20) + "..."
                    : imagePath;

                this.pcbProfile.Image = picture;
            }
        }
    }
}
