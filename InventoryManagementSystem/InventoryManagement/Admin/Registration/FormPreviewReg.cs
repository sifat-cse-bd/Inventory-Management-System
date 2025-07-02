using InventoryManagement.EmailHub;
using InventoryManagement.Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagement.Admin.Registration
{
    public partial class FormPreviewReg : Form
    {
        private App.FormLogin FormLoginRef { get; set; }
        private FormAdminRegistration FormAdminRegistrationRef { get; set; }
        private string SourceImagePath { get; set; }
        private string ID { get; set; } // Assuming ID is needed for the admin registration
        private string Role { get; set; }
        private string JoiningDate { get; set; } // Assuming you want to store the joining date

        private Database.DataAccess Da { get; set; }
        private DateTime DOB { get; set; } // Assuming you want to store the date of birth
        public FormPreviewReg()
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
        }
        public FormPreviewReg(Image picture, string imageFilePath, string name, string email, string phone, DateTime dob, string password, App.FormLogin fl, FormAdminRegistration far)
        {
            InitializeComponent();
            this.pictureBoxProfile.Image = picture;
            this.SourceImagePath = imageFilePath; 
            this.txtName.Text = name;
            this.txtEmail.Text = email;
            this.txtPhone.Text = phone;
            this.txtDateOfBirth.Text = dob.ToString("dd/MM/yyyy"); 
            this.txtPassword.Text = password;
            this.FormLoginRef = fl; 
            this.FormAdminRegistrationRef = far; 
            this.Role = "Admin"; 
            IdGenerator idGen = new IdGenerator();
            this.ID = idGen.GenerateAdminId(); 
            this.txtID.Text = this.ID;
            this.Da = new Database.DataAccess();
            this.DOB = dob; // Store the date of birth
        }

        private void FormPreviewReg_Load(object sender, EventArgs e)
        {
            this.Da = new Database.DataAccess();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.FormLoginRef.Show();//back to home form
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "📝 Are you sure you want to save this admin registration?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return; // User chose not to save
            }
            
            try
            {
                Database.ImageManager im = new Database.ImageManager();

                string destinationImagePath = im.SaveImageToUserFolder(this.SourceImagePath, this.txtName.Text);
                string sql = @"INSERT INTO users VALUES(@userId, @userPassword, @userName, @role, @email, @phone, @savedImagePath, GetDate());
                               INSERT INTO admin VALUES(@userId, @dob);";
                SqlParameter[] userParams = new SqlParameter[]
                {
                    new SqlParameter("@userId", this.txtID.Text),
                    new SqlParameter("@userPassword", this.txtPassword.Text),
                    new SqlParameter("@userName", this.txtName.Text),
                    new SqlParameter("@role", this.Role),
                    new SqlParameter("@email", this.txtEmail.Text),
                    new SqlParameter("@phone", this.txtPhone.Text),
                    new SqlParameter("@savedImagePath", destinationImagePath),
                    new SqlParameter("@dob", this.DOB)
                };

                var count = this.Da.ExecuteDMLQuery(sql, userParams);

                if (count != 2) // Check if both insertions were successful
                {
                    MessageBox.Show("Error saving admin registration. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                 MessageBox.Show("✅ Admin registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.checkBox1.Enabled = true;

                if (checkBox1.Checked)
                {
                    Admin.Activity.FormAdminHome adminHome = new Admin.Activity.FormAdminHome(this.FormLoginRef, this.txtID.Text);
                    adminHome.Show();
                    this.Hide();
                }
                else
                {
                    this.FormLoginRef.Show();
                    this.Hide(); // Return to home form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.FormAdminRegistrationRef.Show(); //back to previous form
            this.Hide(); //hide current form
        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            btnVerify.Enabled = false;
            this.pgsVerify.Visible = true;
            this.lblStatus.Visible = true;

            var currentOtp = OtpManager.GenerateOtp(); // Generate OTP here so btnVerify_Click can use it

            bool sent = await SendOTP(currentOtp); // await async method properly
            if (sent)
            {
                lblStatus.Text = "OTP is Sent.";
                this.pgsVerify.Visible = false;
                this.btnSave.Enabled = true;
                FormOTP fo = new FormOTP(currentOtp, this.txtEmail.Text, txtName.Text, this.Role);
                fo.SetFormPreviewRef(this);
                fo.ShowDialog();
            }
            else
            {
                lblStatus.Text = "Failed to send OTP.";
                this.pgsVerify.Visible = false;
                btnVerify.Enabled = true;
            }
        }

        internal async Task<bool> SendOTP(string otp)
        {
            try
            {
                var sent = await EmailAccess.SendOtpEmailAsync(this.txtEmail.Text, otp, txtName.Text, this.Role);
                return sent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message);
                lblStatus.Text = "Error occurred.";
                btnVerify.Enabled = true;
                return false;
            }
            finally
            {
                // You can hide progress here, but do NOT return in finally
                this.pgsVerify.Visible = false;
            }
        }

    }
}
