using InventoryManagement.Admin.Activity.ManageUser;
using InventoryManagement.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity
{
    public partial class AddSalesmanControl : UserControl
    {
        private string ImageFilePath { get; set; }
        private Database.DataAccess Da { get; set; }
        private string TempUserPassword { get; set; }   
        private string UserID { get; set; } // salesman id
        private string Role { get; set; }
        private FormAdminHome FormAdminHomeRef { get; set; } // Reference to the parent form
        public AddSalesmanControl(FormAdminHome formAdminHomeRef)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.UserID = new Generator.IdGenerator().GenerateSalesmanId();
            this.txtUserID.Text = this.UserID;
            this.Role = "Salesman";
            this.TempUserPassword = TempPassword();
            FormAdminHomeRef = formAdminHomeRef;
        }
        private void AddSalesmanControl_Load(object sender, EventArgs e)
        {
            this.cmbCity.DataSource = Database.AddressBook.GetAllCities();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.FormAdminHomeRef.panelContainer.Controls.Clear();
            this.FormAdminHomeRef.panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ClearFields()
        {
            this.txtName.Clear();
            this.txtEmail.Clear();
            this.txtPhone.Clear();
            this.txtNID.Clear();
            this.rdFemale.Checked = false;
            this.rdMale.Checked = false;
            this.pcbProfile.Image = null;
            this.cmbCity.SelectedIndex = -1;
            this.cmbUpazilla.SelectedIndex = -1;
            this.txtArea.Clear();
            this.txtArea.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private string TempPassword()
        {
            string temp;

            if (!string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                temp = txtName.Text.Split(' ')[0];
            }
            else
            {
                temp = "salesman";
            }
            return temp + DateTime.Now.ToString("HHmmss");
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToNext())
                return;

            SqlTransaction transaction = null;
            try
            {
                Database.ImageManager im = new Database.ImageManager();

                transaction = Da.SqlConn.BeginTransaction();

                string destinationImagePath = im.SaveImageToUserFolder(this.ImageFilePath, this.txtName.Text);

                // insert into Users
                string userSql = @"INSERT INTO Users VALUES(@userId, @userPassword, @userName, @role, @email, @phone, @savedImagePath, GetDate());";
                SqlParameter[] userParams = new SqlParameter[]
                {
                    new SqlParameter("@userId", this.UserID),
                    new SqlParameter("@userPassword", this.TempUserPassword),
                    new SqlParameter("@userName", this.txtName.Text),
                    new SqlParameter("@role", this.Role),
                    new SqlParameter("@email", this.txtEmail.Text),
                    new SqlParameter("@phone", this.txtPhone.Text),
                    new SqlParameter("@savedImagePath", destinationImagePath)
                };
                
                Da.ExecuteDMLQuery(userSql, userParams, transaction);


                // insert into Salesman
                string salesmanSql = @" INSERT INTO Salesman VALUES(@userId, @NID, @gender,  @area, @upazila, @city);";

                SqlParameter[] salesmanParams = new SqlParameter[]
                {
                    new SqlParameter("@userId", this.UserID),
                    new SqlParameter("@NID", this.txtNID.Text),
                    new SqlParameter("@gender", this.rdMale.Checked ? "Male" : "Female"),
                    new SqlParameter("@area", this.txtArea.Text),
                    new SqlParameter("@upazila", this.cmbUpazilla.SelectedItem?.ToString() ?? string.Empty),
                    new SqlParameter("@city", this.cmbCity.SelectedItem?.ToString() ?? string.Empty)
                };
                Da.ExecuteDMLQuery(salesmanSql, salesmanParams, transaction);

                // insert into AdminSalesman
                string adminSalesmanSql = @"INSERT INTO AdminSalesman VALUES(@userId, @adminID); ";
                SqlParameter[] adminSalesmanParams = new SqlParameter[]
                   {
                       new SqlParameter("@userId", this.UserID),
                       new SqlParameter("@adminID", this.FormAdminHomeRef.AdminId)
                   };
                Da.ExecuteDMLQuery(adminSalesmanSql, adminSalesmanParams, transaction);

                transaction.Commit();


                // Finalize the registration
                MessageBox.Show("Salesman registration successful! Temporary password: " + this.TempUserPassword, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewUserControl viewUserControl = new ViewUserControl(this.FormAdminHomeRef);
                this.AddUserControl(viewUserControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsValidToNext()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNID.Text))
            {
                MessageBox.Show("NID number is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNID.Focus();
                return false;
            }

            if (!rdMale.Checked && !rdFemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pcbProfile.Image == null)
            {
                MessageBox.Show("Profile image is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCity.Focus();
                return false;
            }

            if (cmbUpazilla.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an upazila.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUpazilla.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Area is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Focus();
                return false;
            }

            return true;
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

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = cmbCity.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCity))
            {
                cmbUpazilla.DataSource = AddressBook.GetUpazilas(selectedCity);
            }
        }
    }
}
