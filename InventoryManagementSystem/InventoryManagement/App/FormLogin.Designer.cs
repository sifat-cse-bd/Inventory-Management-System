namespace InventoryManagement.App
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSMTP = new Guna.UI2.WinForms.Guna2Button();
            this.btnForgotPasword = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegisterNow = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.txtUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkPasswordVisiblity = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 42);
            this.panel2.TabIndex = 26;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnMinimize.Image = global::InventoryManagement.Properties.Resources.Subtract;
            this.btnMinimize.Location = new System.Drawing.Point(1002, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 36);
            this.btnMinimize.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1047, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 36);
            this.btnClose.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSMTP
            // 
            this.btnSMTP.Animated = true;
            this.btnSMTP.BackColor = System.Drawing.Color.Transparent;
            this.btnSMTP.BorderRadius = 4;
            this.btnSMTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSMTP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSMTP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSMTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSMTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSMTP.FillColor = System.Drawing.Color.Transparent;
            this.btnSMTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSMTP.ForeColor = System.Drawing.Color.Red;
            this.btnSMTP.Location = new System.Drawing.Point(239, 518);
            this.btnSMTP.Name = "btnSMTP";
            this.btnSMTP.Size = new System.Drawing.Size(103, 29);
            this.btnSMTP.TabIndex = 21;
            this.btnSMTP.Text = "SMTP";
            this.btnSMTP.TextOffset = new System.Drawing.Point(-25, 0);
            this.toolTip1.SetToolTip(this.btnSMTP, "During the admin registration process, email verification is required. Therefore," +
        " the system owner must configure the SMTP server in order to receive the OTP.");
            this.btnSMTP.Click += new System.EventHandler(this.btnSMTP_Click);
            // 
            // btnForgotPasword
            // 
            this.btnForgotPasword.Animated = true;
            this.btnForgotPasword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPasword.BorderRadius = 4;
            this.btnForgotPasword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPasword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnForgotPasword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnForgotPasword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForgotPasword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnForgotPasword.FillColor = System.Drawing.Color.Transparent;
            this.btnForgotPasword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnForgotPasword.ForeColor = System.Drawing.Color.White;
            this.btnForgotPasword.Location = new System.Drawing.Point(201, 314);
            this.btnForgotPasword.Name = "btnForgotPasword";
            this.btnForgotPasword.Size = new System.Drawing.Size(183, 27);
            this.btnForgotPasword.TabIndex = 15;
            this.btnForgotPasword.Text = "Forgotten password?";
            this.btnForgotPasword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnForgotPasword.TextOffset = new System.Drawing.Point(5, 0);
            this.toolTip1.SetToolTip(this.btnForgotPasword, "Forgotten password");
            this.btnForgotPasword.Click += new System.EventHandler(this.btnForgotPasword_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Animated = true;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderRadius = 4;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(1)))));
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(31, 349);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(351, 39);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Sign In";
            this.toolTip1.SetToolTip(this.btnSignIn, "Sign in");
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegisterNow);
            this.panel1.Controls.Add(this.btnSMTP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblShopName);
            this.panel1.Controls.Add(this.txtUserPassword);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.chkPasswordVisiblity);
            this.panel1.Controls.Add(this.btnForgotPasword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labUsername);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Location = new System.Drawing.Point(662, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 559);
            this.panel1.TabIndex = 11;
            // 
            // btnRegisterNow
            // 
            this.btnRegisterNow.Animated = true;
            this.btnRegisterNow.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterNow.BorderRadius = 4;
            this.btnRegisterNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisterNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisterNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegisterNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegisterNow.FillColor = System.Drawing.Color.Transparent;
            this.btnRegisterNow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegisterNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(1)))));
            this.btnRegisterNow.Location = new System.Drawing.Point(247, 416);
            this.btnRegisterNow.Name = "btnRegisterNow";
            this.btnRegisterNow.Size = new System.Drawing.Size(103, 29);
            this.btnRegisterNow.TabIndex = 7;
            this.btnRegisterNow.Text = "Sign up";
            this.btnRegisterNow.TextOffset = new System.Drawing.Point(-20, 0);
            this.toolTip1.SetToolTip(this.btnRegisterNow, "Admin Sign up");
            this.btnRegisterNow.Click += new System.EventHandler(this.btnRegisterNow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(113, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Setup SMTP server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(100, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Only admin can sign up here.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Don\'t have a account!";
            // 
            // lblShopName
            // 
            this.lblShopName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.White;
            this.lblShopName.Location = new System.Drawing.Point(107, 19);
            this.lblShopName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(202, 32);
            this.lblShopName.TabIndex = 17;
            this.lblShopName.Text = "MEHEDI MART LTD.";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.txtUserPassword.BorderRadius = 4;
            this.txtUserPassword.BorderThickness = 2;
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.DefaultText = "";
            this.txtUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPassword.Location = new System.Drawing.Point(31, 246);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtUserPassword.PlaceholderText = "Enter Password";
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.Size = new System.Drawing.Size(351, 49);
            this.txtUserPassword.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtUserPassword, "Password");
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.txtUserID.BorderRadius = 4;
            this.txtUserID.BorderThickness = 2;
            this.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(31, 144);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtUserID.PlaceholderText = "Enter User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(351, 49);
            this.txtUserID.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtUserID, "ID");
            // 
            // chkPasswordVisiblity
            // 
            this.chkPasswordVisiblity.AutoSize = true;
            this.chkPasswordVisiblity.BackColor = System.Drawing.Color.Transparent;
            this.chkPasswordVisiblity.ForeColor = System.Drawing.Color.White;
            this.chkPasswordVisiblity.Location = new System.Drawing.Point(30, 318);
            this.chkPasswordVisiblity.Name = "chkPasswordVisiblity";
            this.chkPasswordVisiblity.Size = new System.Drawing.Size(125, 20);
            this.chkPasswordVisiblity.TabIndex = 12;
            this.chkPasswordVisiblity.Text = "Show Password";
            this.toolTip1.SetToolTip(this.chkPasswordVisiblity, "Show password");
            this.chkPasswordVisiblity.UseVisualStyleBackColor = false;
            this.chkPasswordVisiblity.CheckedChanged += new System.EventHandler(this.chkPasswordVisiblity_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Sign in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.BackColor = System.Drawing.Color.Transparent;
            this.labUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.White;
            this.labUsername.Location = new System.Drawing.Point(27, 117);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(68, 21);
            this.labUsername.TabIndex = 10;
            this.labUsername.Text = "User ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1096, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(453, 137);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private System.Windows.Forms.Label labUsername;
        private Guna.UI2.WinForms.Guna2Button btnRegisterNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnForgotPasword;
        private System.Windows.Forms.CheckBox chkPasswordVisiblity;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}