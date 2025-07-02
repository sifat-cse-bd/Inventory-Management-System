using InventoryManagement.Admin;
using InventoryManagement.Admin.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventoryManagement.Salesman
{
    public partial class FormFirst : Form
    {
        string fileName;
        public FormFirst()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private string GenerateTempUsername()
        {
            Random random = new Random();
            
            string[] part = txtName.Text.Split(' ');
            for (int i = 0; i < part.Length; i++)
            {
                part[i] = part[i].ToLower();
            }

            string namePart = part[random.Next(0, (part.Length -1))];
            string temp = random.Next(100, 999).ToString();
            return (namePart + temp).ToLower();
        }

        private string GenerateTempPassword()
        {
            Random rand = new Random();
            string tempPassword = rand.Next(100000, 999999).ToString(); // Generate a random 6-digit number
            return tempPassword; // Return the generated password
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailFormatWarning.Visible = true;
                txtEmail.Focus();
                return;
            }
            else
            {
                // If email format is valid, hide the warning label
                lblEmailFormatWarning.Visible = false;
                return;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone";
                txtPhone.ForeColor = Color.Gray;
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    fileName = filePath;
                    if(filePath.Length > 15)
                    {
                        lblSourceImagePath.Text = "File: " + filePath.Substring(0, 15) + "..."; // Truncate the path if it's too long
                    }
                    else
                    {
                        lblSourceImagePath.Text = "File: " + filePath; // Display the full path if it's short enough
                    }
                        // Display the selected image path

                        using (Image selectedImage = Image.FromFile(filePath))
                        {
                            if (selectedImage.Width != 150 || selectedImage.Height != 150)
                            {
                                MessageBox.Show("⚠️ Please select an image of exactly 150x150 pixels!", "Invalid Image Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            picProfile.Image = CorrectImageOrientation((Image)selectedImage.Clone());
                        }
                }
            }
        }

        public static Image CorrectImageOrientation(Image img)
        {
            try
            {
                if (img.PropertyIdList.Contains(0x0112))
                {
                    var prop = img.GetPropertyItem(0x0112);
                    int val = BitConverter.ToUInt16(prop.Value, 0);

                    switch (val)
                    {
                        case 3:
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                        case 6:
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 8:
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                    }

                    try { img.RemovePropertyItem(0x0112); } catch { }
                }
            }
            catch { }

            return img;
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Email" || txtName.Text == "Name" || txtPhone.Text == "Phone" || picProfile.Image == null)
            {
                MessageBox.Show("Please fill all fields and attach a profile picture.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnVerify.Enabled = false; // Disable the verify button
                btnSave.Enabled = false; // Disable the save button
                pnlOutput.Visible = false; // Hide the output panel
                return;

            }
            else
            {
                this.txtOutputName.Text += txtName.Text;
                this.txtOutputEmail.Text += txtEmail.Text;
                this.txtOutputPhone.Text += txtPhone.Text;
                this.txtOutputUsername.Text += GenerateTempUsername(); // Generate a temporary username based on the name
                this.txtOutputPassword.Text += GenerateTempPassword(); // Generate a temporary password
                this.picOutputProfie.Image = picProfile.Image; // Set the profile picture
                //this.txtOutputID.Text += Generator.IdGenerator.GenerateSalesmanID(); // Generate a unique ID for the salesman
                this.pnlOutput.Visible = true; // Show the output panel
                this.btnVerify.Enabled = true; // Enable the verify button
                this.btnPreview.Enabled = false; // Disable the preview button
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^01[0-9]{9}$";

            if (txtPhone.Text != "Phone")
            {
                if (Regex.IsMatch(txtPhone.Text, pattern))
                {
                    txtPhone.BackColor = Color.White; // Valid input
                    errorProvider1.SetError(txtPhone, ""); // No error
                }

                else
                {
                    txtPhone.BackColor = Color.MistyRose; // Invalid input
                    errorProvider1.SetError(txtPhone, "Invalid phone number format");
                }
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

        private void btnVerify_Click(object sender, EventArgs e)

        {
            


        }

        internal void RefreshFormFirst()
        {
            this.labVerifyMsg.Text = "Verification successful!";
            this.btnSave.Enabled = true; // Enable the save button
            this.btnVerify.Enabled = false; // Disable the verify button
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string role = "Salesman"; // Set the role for the salesman
            //Database.User data = new Database.SalesmanData( role,
            //    this.txtOutputID.Text, 
            //    this.txtOutputName.Text, 
            //    this.txtOutputEmail.Text, 
            //    this.txtOutputPhone.Text, 
            //    this.txtOutputUsername.Text, 
            //    this.txtOutputPassword.Text, 
            //    this.fileName // Assuming you want to save the image path
            //);

            //string query = $"INSERT INTO SALESMAN (SALESMAN_ID, SALESMAN_NAME, SALESMAN_EMAIL, SALESMAN_PHONE, Salesman_USERNAME, SALESMAN_PASSWORD, SALESMAN_PHOTO) VALUES (@ID, @NAME, @EMAIL, @PHONE, @USERNAME, @PASSWORD, @PHOTO)";

            //bool flag = data.Push(query); // Save the data to the database

            //if(flag)
            //{
            //    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();

            //}

            ////string role, string id, string name, string email, string phone, string userName, string password, string sourceImagePath
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Text = "Name"; // Reset name field
            txtName.ForeColor = Color.Gray; // Reset name field color
            txtEmail.Text = "Email"; // Reset email field
            txtEmail.ForeColor = Color.Gray; // Reset email field color
            txtPhone.Text = "Phone"; // Reset phone field
            txtPhone.ForeColor = Color.Gray; // Reset phone field color
            btnPreview.Enabled = true; // Enable the preview button
        }
    }
}
