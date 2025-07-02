using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement.App
{
    public partial class FormSMTP : Form
    {
        Database.DataAccess Da { get; set; }
        App.FormLogin FormLoginRef { get; set; }

        public FormSMTP(FormLogin formLoginRef)
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.CheckSmtpConfiguration();
            FormLoginRef = formLoginRef;
        }

        private void FormSMTP_Load(object sender, EventArgs e)
        {
            this.CheckSmtpConfiguration();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtEmail.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill in both Email and Password.");
                    return;
                }

                // Optional: Email format validation
                if (!this.txtEmail.Text.Contains("@") || !this.txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Check if SMTP already configured
                if (IsSmtpAlreadyConfigured())
                {
                    MessageBox.Show("SMTP is already configured. Cannot add another entry.");
                    return;
                }

                var sql = "INSERT INTO SMTP VALUES (@email, @password);";
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@email", this.txtEmail.Text),
                    new SqlParameter("@password", this.txtPassword.Text)
                };

                var count = Da.ExecuteDMLQuery(sql, para);

                if (count == 1)
                {
                    MessageBox.Show("SMTP server setup successfully. Now ready to sign up admin.");

                    //this.CheckSmtpConfiguration(); // Refresh UI
                    this.Hide();
                    this.FormLoginRef.Show();
                }
                else
                {
                    MessageBox.Show("Setup failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsSmtpAlreadyConfigured()
        {
            try
            {
                var sql = "SELECT * FROM SMTP;";
                var dt = this.Da.ExecuteQueryTable(sql);

                return dt.Rows.Count >= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking SMTP configuration: " + ex.Message);
                return false;
            }
        }

        private void CheckSmtpConfiguration()
        {
            try
            {
                if (IsSmtpAlreadyConfigured())
                {
                    this.lblStatus.Visible = true;
                    this.lblStatus.Text = "SMTP is already configured.";
                    this.pnlContainer.Visible = false;
                }
                else
                {
                    this.lblStatus.Visible = false;
                    this.pnlContainer.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading SMTP configuration: " + ex.Message);
            }
        }
    }
}
