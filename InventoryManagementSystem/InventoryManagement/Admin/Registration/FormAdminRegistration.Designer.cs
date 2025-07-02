namespace InventoryManagement.Admin
{
    partial class FormAdminRegistration
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
            System.Windows.Forms.Panel panel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminRegistration));
            this.lblPhoneFormat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEmailFormatWarning = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.chkPasswordVisiblity = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peviewPanel = new System.Windows.Forms.Panel();
            this.pictureContainerPanel = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.lblImageFileName = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.peviewPanel.SuspendLayout();
            this.pictureContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            panel2.Controls.Add(this.lblPhoneFormat);
            panel2.Controls.Add(this.label1);
            panel2.Controls.Add(this.dtpDOB);
            panel2.Controls.Add(this.lblEmailFormatWarning);
            panel2.Controls.Add(this.btnBack);
            panel2.Controls.Add(this.chkPasswordVisiblity);
            panel2.Controls.Add(this.label10);
            panel2.Controls.Add(this.label7);
            panel2.Controls.Add(this.label8);
            panel2.Controls.Add(this.label5);
            panel2.Controls.Add(this.label4);
            panel2.Controls.Add(this.label3);
            panel2.Controls.Add(this.label2);
            panel2.Controls.Add(this.txtPassword);
            panel2.Controls.Add(this.txtPhone);
            panel2.Controls.Add(this.txtEmail);
            panel2.Controls.Add(this.txtName);
            panel2.Controls.Add(this.pictureBox1);
            panel2.Controls.Add(this.peviewPanel);
            panel2.Controls.Add(this.btnPreview);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1062, 515);
            panel2.TabIndex = 32;
            // 
            // lblPhoneFormat
            // 
            this.lblPhoneFormat.AutoSize = true;
            this.lblPhoneFormat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhoneFormat.Location = new System.Drawing.Point(462, 235);
            this.lblPhoneFormat.Name = "lblPhoneFormat";
            this.lblPhoneFormat.Size = new System.Drawing.Size(183, 16);
            this.lblPhoneFormat.TabIndex = 43;
            this.lblPhoneFormat.Text = "Invalid contact number format.";
            this.lblPhoneFormat.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(462, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "day/month/year";
            this.label1.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDOB.BorderRadius = 2;
            this.dtpDOB.BorderThickness = 1;
            this.dtpDOB.Checked = true;
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(458, 257);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(308, 38);
            this.dtpDOB.TabIndex = 41;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblEmailFormatWarning
            // 
            this.lblEmailFormatWarning.AutoSize = true;
            this.lblEmailFormatWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmailFormatWarning.Location = new System.Drawing.Point(461, 171);
            this.lblEmailFormatWarning.Name = "lblEmailFormatWarning";
            this.lblEmailFormatWarning.Size = new System.Drawing.Size(125, 16);
            this.lblEmailFormatWarning.TabIndex = 40;
            this.lblEmailFormatWarning.Text = "Invalid email format.";
            this.lblEmailFormatWarning.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(763, 459);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 34);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkPasswordVisiblity
            // 
            this.chkPasswordVisiblity.AutoSize = true;
            this.chkPasswordVisiblity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(8)))));
            this.chkPasswordVisiblity.Location = new System.Drawing.Point(460, 367);
            this.chkPasswordVisiblity.Name = "chkPasswordVisiblity";
            this.chkPasswordVisiblity.Size = new System.Drawing.Size(125, 20);
            this.chkPasswordVisiblity.TabIndex = 33;
            this.chkPasswordVisiblity.Text = "Show Password";
            this.chkPasswordVisiblity.UseVisualStyleBackColor = true;
            this.chkPasswordVisiblity.CheckedChanged += new System.EventHandler(this.chkPasswordVisiblity_CheckedChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label10.Location = new System.Drawing.Point(328, 321);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(118, 38);
            this.label10.TabIndex = 37;
            this.label10.Text = "Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label7.Location = new System.Drawing.Point(328, 257);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(118, 38);
            this.label7.TabIndex = 36;
            this.label7.Text = "Date Of Birth";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(328, 193);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(118, 38);
            this.label8.TabIndex = 35;
            this.label8.Text = "Phone";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(328, 129);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(118, 38);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(328, 65);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(118, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(785, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Photo Dimension must be 150 x 150";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Create an account";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(458, 321);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(308, 38);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 2;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(458, 193);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Enter Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(308, 38);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(458, 129);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter  Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(308, 38);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BorderRadius = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(458, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(308, 38);
            this.txtName.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // peviewPanel
            // 
            this.peviewPanel.Controls.Add(this.pictureContainerPanel);
            this.peviewPanel.Controls.Add(this.lblImageFileName);
            this.peviewPanel.Controls.Add(this.btnAttach);
            this.peviewPanel.Location = new System.Drawing.Point(788, 65);
            this.peviewPanel.Name = "peviewPanel";
            this.peviewPanel.Size = new System.Drawing.Size(199, 256);
            this.peviewPanel.TabIndex = 16;
            // 
            // pictureContainerPanel
            // 
            this.pictureContainerPanel.BackColor = System.Drawing.Color.White;
            this.pictureContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureContainerPanel.Controls.Add(this.pictureBoxProfile);
            this.pictureContainerPanel.Location = new System.Drawing.Point(21, 12);
            this.pictureContainerPanel.Name = "pictureContainerPanel";
            this.pictureContainerPanel.Size = new System.Drawing.Size(160, 160);
            this.pictureContainerPanel.TabIndex = 11;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.BackgroundImage")));
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfile.InitialImage = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(5, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 12;
            this.pictureBoxProfile.TabStop = false;
            // 
            // lblImageFileName
            // 
            this.lblImageFileName.ForeColor = System.Drawing.Color.White;
            this.lblImageFileName.Location = new System.Drawing.Point(22, 182);
            this.lblImageFileName.Name = "lblImageFileName";
            this.lblImageFileName.Size = new System.Drawing.Size(158, 16);
            this.lblImageFileName.TabIndex = 22;
            this.lblImageFileName.Text = "No image chosen";
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttach.Location = new System.Drawing.Point(54, 207);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAttach.Size = new System.Drawing.Size(94, 36);
            this.btnAttach.TabIndex = 21;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(8)))));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Black;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(902, 459);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(127, 34);
            this.btnPreview.TabIndex = 23;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(51, 6);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Size = new System.Drawing.Size(288, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "MEHEDI MART LTD. | ADMIN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 45);
            this.panel1.TabIndex = 15;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(10, -1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 42;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1006, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 45);
            this.btnHome.TabIndex = 16;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormAdminRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 560);
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCreateForm";
            this.Load += new System.EventHandler(this.FromAdminRegistration_Load);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.peviewPanel.ResumeLayout(false);
            this.pictureContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel peviewPanel;
        private System.Windows.Forms.Panel pictureContainerPanel;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblImageFileName;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkPasswordVisiblity;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblEmailFormatWarning;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhoneFormat;
    }
}