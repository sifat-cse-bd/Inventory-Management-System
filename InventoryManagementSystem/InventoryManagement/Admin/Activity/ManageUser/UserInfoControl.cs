using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity.ManageUser
{
    public partial class UserInfoControl : UserControl
    {
        private Database.DataAccess Da { get; set; }
        private ViewUserControl ControlRef { get; set; }
        private string SelectedUserID { get; set; }
        private string SelectedPassword { get; set; }
        private string SelectedJoiningDate { get; set; }
        private string SelectedUserRole { get; set; }
        private string SelectedUserName { get; set; }
        private string SelectedPhone { get; set; }
        private string SelectedEmail { get; set; }
        private string SelectedDateOfBirth { get; set; }
        private string SelectedGender { get; set; }
        private string SelectedNID { get; set; }
        private string SelectedCity { get; set; }
        private string SelectedUpazilla { get; set; }
        private string SelectedArea { get; set; }
        private string ImageFilePath { get; set; }

        public UserInfoControl(ViewUserControl control, string userId, string imagePath)
        {
            InitializeComponent();
            ControlRef = control;
            SelectedUserID = userId;
            ImageFilePath = imagePath;
            Da = new Database.DataAccess();

            cmbCity.DataSource = Database.AddressBook.GetAllCities();
            cmbCity.SelectedIndex = -1;
            cmbUpazilla.SelectedIndex = -1;
        }

        private void UserInfoControl_Load(object sender, EventArgs e)
        {
            PopulateUserInfo();
        }

        private void PopulateUserInfo()
        {
            try
            {
                var sql = "SELECT * FROM Users WHERE U_ID = @userId;";
                var parameters = new SqlParameter[] { new SqlParameter("@userId", SelectedUserID) };
                var dt = Da.ExecuteQueryTable(sql, parameters);

                if (dt.Rows.Count == 1)
                {
                    var row = dt.Rows[0];
                    SelectedUserName = row["U_Name"].ToString();
                    SelectedEmail = row["U_Email"].ToString();
                    SelectedUserRole = row["U_Role"].ToString();
                    SelectedPhone = row["U_Phone"].ToString();
                    SelectedPassword = row["U_Password"].ToString();
                    SelectedJoiningDate = Convert.ToDateTime(row["U_Joining_Date"]).ToString("dd/MMM/yyyy");

                    lblID.Text += SelectedUserID;
                    lblProfileName.Text = SelectedUserName;
                    lblEmailAddress.Text = SelectedEmail;
                    lblRole.Text = SelectedUserRole;
                    lblJoiningDate.Text += SelectedJoiningDate;
                    lblPhone.Text += SelectedPhone;

                    if (SelectedUserRole == "Admin")
                    {
                        pnlAdmin.Visible = true;
                        pnlForSalesman.Visible = false;
                        flpAdditional.Height = 130;
                        pnlProfileSettings.Height = 539;
                    }
                    else if (SelectedUserRole == "Salesman")
                    {
                        pnlAdmin.Visible = false;
                        pnlForSalesman.Visible = true;
                        flpAdditional.Height = 190;
                        pnlProfileSettings.Height = 478;
                    }

                    if (File.Exists(this.ImageFilePath))
                    {

                        pcbProfile.Image = Image.FromFile(this.ImageFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Image not found!");
                        pcbProfile.Image = null;
                    }

                    GetUserAdditionalInfo(SelectedUserRole);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUserAdditionalInfo(string role)
        {
            try
            {
                string query = "";
                switch (role)
                {
                    case "Admin":
                        query = $"Select * from {role} where A_ID = @userId;";
                        break;
                    case "Salesman":
                        query = $"Select * from {role} where S_ID = @userId;";
                        break;
                }

                SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("@userId", this.SelectedUserID)
                };

                var dt = Da.ExecuteQueryTable(query, parameter);
                if (dt.Rows.Count == 1 && role == "Admin")
                {
                    this.SelectedDateOfBirth = Convert.ToDateTime(dt.Rows[0]["A_DOB"]).ToString("dd/MMM/yyyy");
                    this.lblDateOfBirth.Text += this.SelectedDateOfBirth;
                }
                else
                {
                    this.lblDateOfBirth.Text += "N/A";
                }

                //again
                if (dt.Rows.Count == 1 && role == "Salesman")
                {
                    this.SelectedGender = dt.Rows[0]["Gender"].ToString();
                    this.SelectedNID = dt.Rows[0]["S_NID"].ToString();
                    this.SelectedCity = dt.Rows[0]["S_City"].ToString();
                    this.SelectedUpazilla = dt.Rows[0]["S_Upazilla"].ToString();
                    this.SelectedArea = dt.Rows[0]["S_Area"].ToString();

                    this.lblGender.Text += this.SelectedGender;
                    this.lblNID.Text += this.SelectedNID;
                    this.lblAddress.Text += $"{this.SelectedArea}, {this.SelectedUpazilla}, {this.SelectedCity}";
                }
                else
                {
                    this.lblGender.Text = "N/A";
                    this.lblNID.Text = "N/A";
                    this.lblAddress.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving additional info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem != null)
            {
                var selectedCity = cmbCity.SelectedItem.ToString();
                cmbUpazilla.DataSource = Database.AddressBook.GetUpazilas(selectedCity);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = btnChangePictue.Enabled = true;

            txtname.Text = SelectedUserName;
            txtEmail.Text = SelectedEmail;
            txtPhone.Text = SelectedPhone;
            txtPassword.Text = SelectedPassword;

            if (SelectedUserRole == "Admin")
            {
                txtname.Enabled = txtEmail.Enabled = txtPhone.Enabled = txtPassword.Enabled = true;
                dtpDOB.Enabled = true;
                pnlProfileSetting2.Enabled = true;

                if (DateTime.TryParse(SelectedDateOfBirth, out DateTime dob))
                    dtpDOB.Value = dob;
                else
                    dtpDOB.Value = DateTime.Today;
            }
            else if (SelectedUserRole == "Salesman")
            {
                txtname.Enabled = txtEmail.Enabled = txtPhone.Enabled = txtPassword.Enabled = true;
                txtNID.Enabled = txtArea.Enabled = true;
                cmbCity.Enabled = cmbUpazilla.Enabled = cmbGender.Enabled = true;
                pnlProfileSetting2.Enabled = true;

                cmbCity.SelectedItem = SelectedCity;
                cmbUpazilla.SelectedItem = SelectedUpazilla;
                txtArea.Text = SelectedArea;
                cmbGender.SelectedItem = SelectedGender;
                txtNID.Text = SelectedNID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.SelectedUserRole == "Admin")
            {
                if (IsValidToSaveAdmin())
                    UpdateAdmin();
            }
            else
            {
                if (IsValidToSaveSalesman())
                    UpdateSalesman();
            }
        }

        private bool IsValidToSaveAdmin()
        {
            if (string.IsNullOrEmpty(ImageFilePath))
            {
                MessageBox.Show("Photo cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("All fields must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidToSaveSalesman()
        {
            // Common Fields
            if (string.IsNullOrEmpty(ImageFilePath))
            {
                MessageBox.Show("Photo cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Salesman-specific Fields
            if (string.IsNullOrEmpty(txtNID.Text))
            {
                MessageBox.Show("NID cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCity.SelectedItem == null)
            {
                MessageBox.Show("Please select a city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbUpazilla.SelectedItem == null)
            {
                MessageBox.Show("Please select an upazilla.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtArea.Text))
            {
                MessageBox.Show("Area cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void UpdateAdmin()
        {
            var transaction = BeginTransaction();
            try
            {
                var sql = @"UPDATE users 
                            SET U_Photo = @photo, U_Name = @name, U_Email = @email, U_Phone = @phone, U_Password = @password
                            WHERE U_ID = @id";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@photo", ImageFilePath),
                    new SqlParameter("@name", txtname.Text),
                    new SqlParameter("@email", txtEmail.Text),
                    new SqlParameter("@phone", txtPhone.Text),
                    new SqlParameter("@password", txtPassword.Text),
                    new SqlParameter("@id", SelectedUserID)
                };

                Da.ExecuteDMLQuery(sql, parameters, transaction);

                var sql2 = @"UPDATE Admin SET A_DOB = @dob WHERE A_ID = @id";
                var parameters2 = new SqlParameter[]
                {
                    new SqlParameter("@dob", dtpDOB.Value),
                    new SqlParameter("@id", SelectedUserID)
                };

                Da.ExecuteDMLQuery(sql2, parameters2, transaction);
                transaction.Commit();

                MessageBox.Show("Admin profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error updating admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSalesman()
        {
            var transaction = BeginTransaction();
            try
            {
                var sql = @"UPDATE users 
                            SET U_Photo = @photo, U_Name = @name, U_Email = @email, U_Phone = @phone, U_Password = @password
                            WHERE U_ID = @id";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@photo", ImageFilePath),
                    new SqlParameter("@name", txtname.Text),
                    new SqlParameter("@email", txtEmail.Text),
                    new SqlParameter("@phone", txtPhone.Text),
                    new SqlParameter("@password", txtPassword.Text),
                    new SqlParameter("@id", SelectedUserID)
                };

                Da.ExecuteDMLQuery(sql, parameters, transaction);

                var sql2 = @"UPDATE Salesman 
                            SET S_NID = @nid, Gender = @gender, S_Area = @area, S_Upazilla = @upazilla, S_City = @city
                            WHERE S_ID = @id";

                var parameters2 = new SqlParameter[]
                {
                    new SqlParameter("@nid", txtNID.Text),
                    new SqlParameter("@gender", cmbGender.SelectedItem?.ToString() ?? "N/A"),
                    new SqlParameter("@area", txtArea.Text),
                    new SqlParameter("@upazilla", cmbUpazilla.SelectedItem?.ToString() ?? "N/A"),
                    new SqlParameter("@city", cmbCity.SelectedItem?.ToString() ?? "N/A"),
                    new SqlParameter("@id", SelectedUserID)
                };

                Da.ExecuteDMLQuery(sql2, parameters2, transaction);
                transaction.Commit();

                MessageBox.Show("Salesman profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error updating salesman: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SqlTransaction BeginTransaction()
        {
            if (Da.SqlConn.State != ConnectionState.Open)
                Da.SqlConn.Open();
            return Da.SqlConn.BeginTransaction();
        }

        private void btnChangePictue_Click(object sender, EventArgs e)
        {
            string imagePath;
            Image picture;
            var imageManager = new Database.ImageManager();
            if (imageManager.OpenFileExplorer(out imagePath, out picture))
            {
                ImageFilePath = imagePath;
                pcbProfile.Image = picture;
            }
        }
    }
}
