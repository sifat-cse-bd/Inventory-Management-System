namespace InventoryManagement.EmailHub
{
    partial class FormOTP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOTP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labOtpTimer = new System.Windows.Forms.Label();
            this.txtOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnResend = new Guna.UI2.WinForms.Guna2Button();
            this.otpPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.otpTimer = new System.Windows.Forms.Timer(this.components);
            this.otpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(82, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verify Your Identity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(77, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "An OTP has been sent to your email.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "OTP (one time pin)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labOtpTimer
            // 
            this.labOtpTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOtpTimer.ForeColor = System.Drawing.Color.Red;
            this.labOtpTimer.Location = new System.Drawing.Point(218, 161);
            this.labOtpTimer.Name = "labOtpTimer";
            this.labOtpTimer.Size = new System.Drawing.Size(187, 27);
            this.labOtpTimer.TabIndex = 3;
            this.labOtpTimer.Text = "Remaining Time: 01:30";
            this.labOtpTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOTP
            // 
            this.txtOTP.Animated = true;
            this.txtOTP.BorderColor = System.Drawing.Color.Black;
            this.txtOTP.BorderThickness = 2;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.DefaultText = "";
            this.txtOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.Black;
            this.txtOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOTP.Location = new System.Drawing.Point(20, 189);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.PlaceholderText = "Enter OTP";
            this.txtOTP.SelectedText = "";
            this.txtOTP.Size = new System.Drawing.Size(385, 49);
            this.txtOTP.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(93)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(20, 277);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(137, 50);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnResend
            // 
            this.btnResend.BorderColor = System.Drawing.Color.Transparent;
            this.btnResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResend.Enabled = false;
            this.btnResend.FillColor = System.Drawing.Color.Gray;
            this.btnResend.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnResend.ForeColor = System.Drawing.Color.White;
            this.btnResend.Location = new System.Drawing.Point(268, 277);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(137, 50);
            this.btnResend.TabIndex = 6;
            this.btnResend.Text = "Resend";
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // otpPanel
            // 
            this.otpPanel.Controls.Add(this.btnCancel);
            this.otpPanel.Controls.Add(this.btnResend);
            this.otpPanel.Controls.Add(this.btnConfirm);
            this.otpPanel.Controls.Add(this.txtOTP);
            this.otpPanel.Controls.Add(this.labOtpTimer);
            this.otpPanel.Controls.Add(this.label3);
            this.otpPanel.Controls.Add(this.label2);
            this.otpPanel.Controls.Add(this.label1);
            this.otpPanel.Location = new System.Drawing.Point(13, 15);
            this.otpPanel.Name = "otpPanel";
            this.otpPanel.Size = new System.Drawing.Size(429, 349);
            this.otpPanel.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(389, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(40, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "X";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // otpTimer
            // 
            this.otpTimer.Interval = 1000;
            this.otpTimer.Tick += new System.EventHandler(this.otpTimer_Tick);
            // 
            // FormOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 393);
            this.Controls.Add(this.otpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOTP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtpForm";
            this.Load += new System.EventHandler(this.FormOTP_Load);
            this.otpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labOtpTimer;
        private Guna.UI2.WinForms.Guna2TextBox txtOTP;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnResend;
        private System.Windows.Forms.Panel otpPanel;
        private System.Windows.Forms.Timer otpTimer;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}