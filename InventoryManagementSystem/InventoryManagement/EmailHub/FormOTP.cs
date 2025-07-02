using InventoryManagement.Admin.Registration;
using InventoryManagement.App;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.EmailHub
{
    public partial class FormOTP : Form
    {
        private int remainingSeconds = 90;
        private string CurrentOTP { get; set; }
        private string Email { get; set; }
        private string UserName { get; set; }
        private string Role { get; set; }

        // Flags and references
        internal bool IsVerified { get; private set; } = false;
        internal FormPreviewReg FormPreviewRef { get; private set; }
        internal Admin.Activity.AddAdminControl AdminControlRef { get; private set; }
        internal Admin.Activity.AddSalesmanControl SalesmanControlRef{ get; private set; }

        public FormOTP(string currentOtp, string email, string name, string role)
        {
            InitializeComponent();
            CurrentOTP = currentOtp;
            Email = email;
            this.Name = name;
            Role = role;
        }

        internal void SetFormPreviewRef(FormPreviewReg form)
        {
            this.FormPreviewRef = form;
        }

        internal void SetAdminControlRef(Admin.Activity.AddAdminControl form)
        {
            this.AdminControlRef = form;
        }

        internal void SetSalesmanControlRef(Admin.Activity.AddSalesmanControl form)
        {
            this.SalesmanControlRef = form;
        }

        private void FormOTP_Load(object sender, EventArgs e)
        {
            StartOtpTimer();
            btnResend.Enabled = false;
            btnConfirm.Enabled = true;
            labOtpTimer.ForeColor = Color.Black;
        }

        private void StartOtpTimer()
        {
            remainingSeconds = 90;
            labOtpTimer.Text = $"Remaining Time: 01:30";
            otpTimer.Start();
        }

        private void otpTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                labOtpTimer.Text = $"Remaining Time: {remainingSeconds / 60:D2}:{remainingSeconds % 60:D2}";
            }
            else
            {
                otpTimer.Stop();
                OtpManager.ClearOtp();
                labOtpTimer.Text = "OTP expired!";
                labOtpTimer.ForeColor = Color.Red;
                btnResend.Enabled = true;
                btnConfirm.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string enteredOtp = this.txtOTP.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredOtp))
            {
                MessageBox.Show("Please enter the OTP.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredOtp == this.CurrentOTP)
            {
                otpTimer.Stop();
                IsVerified = true;
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnResend_Click(object sender, EventArgs e)
        {
            CurrentOTP = OtpManager.GenerateOtp();
            bool sent = await SendOTP(CurrentOTP);

            if (sent)
            {
                StartOtpTimer();
                btnResend.Enabled = false;
                btnConfirm.Enabled = true;
                labOtpTimer.ForeColor = Color.Black;
            }
        }

        internal async Task<bool> SendOTP(string otp)
        {
            try
            {
                return await EmailAccess.SendOtpEmailAsync(Email, otp, Name, Role);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (IsVerified)
            {
                this.Close();
            }
            else
            {
                if(FormPreviewRef != null)
                {
                    FormPreviewRef.btnVerify.Enabled = true;
                    FormPreviewRef.btnSave.Enabled= false;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IsVerified)
            {
                this.Close();
            }
            else
            {
                if (FormPreviewRef != null)
                {
                    FormPreviewRef.btnVerify.Enabled = true;
                    FormPreviewRef.btnSave.Enabled = false;
                    this.Close();
                }
            }
        }
    }
}
