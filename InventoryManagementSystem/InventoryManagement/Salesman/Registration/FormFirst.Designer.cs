namespace InventoryManagement.Salesman
{
    partial class FormFirst
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
            System.Windows.Forms.Panel panel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirst));
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.picOutputProfie = new System.Windows.Forms.PictureBox();
            this.txtOutputPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOutputID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOutputUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOutputPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOutputEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlVarifyMsg = new System.Windows.Forms.Panel();
            this.labVerifyMsg = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblSourceImagePath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmailFormatWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNID = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutputProfie)).BeginInit();
            this.pnlVarifyMsg.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            panel2.Controls.Add(this.btnEdit);
            panel2.Controls.Add(this.btnVerify);
            panel2.Controls.Add(this.btnBack);
            panel2.Controls.Add(this.btnSave);
            panel2.Controls.Add(this.pnlOutput);
            panel2.Controls.Add(this.pnlVarifyMsg);
            panel2.Controls.Add(this.panel3);
            panel2.Controls.Add(this.panel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1062, 583);
            panel2.TabIndex = 33;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Green;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Enabled = false;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerify.Location = new System.Drawing.Point(859, 522);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(85, 35);
            this.btnVerify.TabIndex = 46;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(781, 522);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 35);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(155)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(960, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 35);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlOutput
            // 
            this.pnlOutput.BackColor = System.Drawing.SystemColors.Window;
            this.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutput.Controls.Add(this.txtNID);
            this.pnlOutput.Controls.Add(this.picOutputProfie);
            this.pnlOutput.Controls.Add(this.txtOutputPassword);
            this.pnlOutput.Controls.Add(this.txtOutputID);
            this.pnlOutput.Controls.Add(this.txtOutputUsername);
            this.pnlOutput.Controls.Add(this.txtOutputPhone);
            this.pnlOutput.Controls.Add(this.txtOutputEmail);
            this.pnlOutput.Controls.Add(this.label1);
            this.pnlOutput.Controls.Add(this.txtOutputName);
            this.pnlOutput.Location = new System.Drawing.Point(747, 25);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(287, 452);
            this.pnlOutput.TabIndex = 43;
            this.pnlOutput.Visible = false;
            this.pnlOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(641, 528);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEdit.Size = new System.Drawing.Size(40, 29);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // picOutputProfie
            // 
            this.picOutputProfie.BackColor = System.Drawing.Color.Transparent;
            this.picOutputProfie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOutputProfie.BackgroundImage")));
            this.picOutputProfie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOutputProfie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOutputProfie.InitialImage = null;
            this.picOutputProfie.Location = new System.Drawing.Point(94, 55);
            this.picOutputProfie.Name = "picOutputProfie";
            this.picOutputProfie.Size = new System.Drawing.Size(85, 85);
            this.picOutputProfie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutputProfie.TabIndex = 13;
            this.picOutputProfie.TabStop = false;
            // 
            // txtOutputPassword
            // 
            this.txtOutputPassword.Animated = true;
            this.txtOutputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtOutputPassword.BorderRadius = 2;
            this.txtOutputPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtOutputPassword.BorderThickness = 0;
            this.txtOutputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputPassword.DefaultText = "Password: ";
            this.txtOutputPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputPassword.ForeColor = System.Drawing.Color.Black;
            this.txtOutputPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputPassword.Location = new System.Drawing.Point(14, 399);
            this.txtOutputPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOutputPassword.Name = "txtOutputPassword";
            this.txtOutputPassword.PlaceholderText = "";
            this.txtOutputPassword.ReadOnly = true;
            this.txtOutputPassword.SelectedText = "";
            this.txtOutputPassword.Size = new System.Drawing.Size(240, 29);
            this.txtOutputPassword.TabIndex = 45;
            // 
            // txtOutputID
            // 
            this.txtOutputID.Animated = true;
            this.txtOutputID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtOutputID.BorderRadius = 2;
            this.txtOutputID.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtOutputID.BorderThickness = 0;
            this.txtOutputID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputID.DefaultText = "ID: ";
            this.txtOutputID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputID.ForeColor = System.Drawing.Color.Black;
            this.txtOutputID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputID.Location = new System.Drawing.Point(14, 159);
            this.txtOutputID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOutputID.Name = "txtOutputID";
            this.txtOutputID.PlaceholderText = "";
            this.txtOutputID.ReadOnly = true;
            this.txtOutputID.SelectedText = "";
            this.txtOutputID.Size = new System.Drawing.Size(240, 29);
            this.txtOutputID.TabIndex = 44;
            // 
            // txtOutputUsername
            // 
            this.txtOutputUsername.Animated = true;
            this.txtOutputUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtOutputUsername.BorderRadius = 2;
            this.txtOutputUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtOutputUsername.BorderThickness = 0;
            this.txtOutputUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputUsername.DefaultText = "Gender: ";
            this.txtOutputUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputUsername.ForeColor = System.Drawing.Color.Black;
            this.txtOutputUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputUsername.Location = new System.Drawing.Point(14, 319);
            this.txtOutputUsername.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOutputUsername.Name = "txtOutputUsername";
            this.txtOutputUsername.PlaceholderText = "";
            this.txtOutputUsername.ReadOnly = true;
            this.txtOutputUsername.SelectedText = "";
            this.txtOutputUsername.Size = new System.Drawing.Size(240, 29);
            this.txtOutputUsername.TabIndex = 43;
            // 
            // txtOutputPhone
            // 
            this.txtOutputPhone.Animated = true;
            this.txtOutputPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtOutputPhone.BorderRadius = 2;
            this.txtOutputPhone.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtOutputPhone.BorderThickness = 0;
            this.txtOutputPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputPhone.DefaultText = "Phone: ";
            this.txtOutputPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputPhone.ForeColor = System.Drawing.Color.Black;
            this.txtOutputPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputPhone.Location = new System.Drawing.Point(14, 279);
            this.txtOutputPhone.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOutputPhone.Name = "txtOutputPhone";
            this.txtOutputPhone.PlaceholderText = "";
            this.txtOutputPhone.ReadOnly = true;
            this.txtOutputPhone.SelectedText = "";
            this.txtOutputPhone.Size = new System.Drawing.Size(240, 29);
            this.txtOutputPhone.TabIndex = 42;
            // 
            // txtOutputEmail
            // 
            this.txtOutputEmail.Animated = true;
            this.txtOutputEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtOutputEmail.BorderRadius = 2;
            this.txtOutputEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtOutputEmail.BorderThickness = 0;
            this.txtOutputEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputEmail.DefaultText = "Email: ";
            this.txtOutputEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputEmail.ForeColor = System.Drawing.Color.Black;
            this.txtOutputEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputEmail.Location = new System.Drawing.Point(14, 239);
            this.txtOutputEmail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOutputEmail.Name = "txtOutputEmail";
            this.txtOutputEmail.PlaceholderText = "";
            this.txtOutputEmail.ReadOnly = true;
            this.txtOutputEmail.SelectedText = "";
            this.txtOutputEmail.Size = new System.Drawing.Size(240, 29);
            this.txtOutputEmail.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Preview Salesman Info";
            // 
            // txtOutputName
            // 
            this.txtOutputName.Animated = true;
            this.txtOutputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtOutputName.BorderRadius = 2;
            this.txtOutputName.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtOutputName.BorderThickness = 0;
            this.txtOutputName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputName.DefaultText = "Name: ";
            this.txtOutputName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputName.ForeColor = System.Drawing.Color.Black;
            this.txtOutputName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutputName.Location = new System.Drawing.Point(14, 199);
            this.txtOutputName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.PlaceholderText = "";
            this.txtOutputName.ReadOnly = true;
            this.txtOutputName.SelectedText = "";
            this.txtOutputName.Size = new System.Drawing.Size(240, 29);
            this.txtOutputName.TabIndex = 40;
            // 
            // pnlVarifyMsg
            // 
            this.pnlVarifyMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.pnlVarifyMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVarifyMsg.Controls.Add(this.labVerifyMsg);
            this.pnlVarifyMsg.Location = new System.Drawing.Point(26, 431);
            this.pnlVarifyMsg.Name = "pnlVarifyMsg";
            this.pnlVarifyMsg.Size = new System.Drawing.Size(697, 46);
            this.pnlVarifyMsg.TabIndex = 42;
            // 
            // labVerifyMsg
            // 
            this.labVerifyMsg.AutoSize = true;
            this.labVerifyMsg.BackColor = System.Drawing.Color.Transparent;
            this.labVerifyMsg.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVerifyMsg.ForeColor = System.Drawing.Color.Black;
            this.labVerifyMsg.Location = new System.Drawing.Point(90, 12);
            this.labVerifyMsg.Name = "labVerifyMsg";
            this.labVerifyMsg.Size = new System.Drawing.Size(494, 18);
            this.labVerifyMsg.TabIndex = 24;
            this.labVerifyMsg.Text = "🔒 An OTP will be sent to your email after clicking the Verify button.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.picProfile);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnAttach);
            this.panel3.Controls.Add(this.lblSourceImagePath);
            this.panel3.Controls.Add(this.btnPreview);
            this.panel3.Location = new System.Drawing.Point(485, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 381);
            this.panel3.TabIndex = 41;
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProfile.BackgroundImage")));
            this.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.InitialImage = null;
            this.picProfile.Location = new System.Drawing.Point(45, 14);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(150, 150);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 24;
            this.picProfile.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Photo Dimension must be 150 x 150";
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttach.Location = new System.Drawing.Point(26, 253);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAttach.Size = new System.Drawing.Size(189, 38);
            this.btnAttach.TabIndex = 21;
            this.btnAttach.Text = "Upload";
            this.btnAttach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblSourceImagePath
            // 
            this.lblSourceImagePath.BackColor = System.Drawing.Color.Transparent;
            this.lblSourceImagePath.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceImagePath.ForeColor = System.Drawing.Color.Black;
            this.lblSourceImagePath.Location = new System.Drawing.Point(24, 176);
            this.lblSourceImagePath.Name = "lblSourceImagePath";
            this.lblSourceImagePath.Size = new System.Drawing.Size(193, 38);
            this.lblSourceImagePath.TabIndex = 39;
            this.lblSourceImagePath.Text = "No file Choosen";
            this.lblSourceImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.guna2RadioButton2);
            this.panel1.Controls.Add(this.guna2RadioButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblEmailFormatWarning);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(26, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 382);
            this.panel1.TabIndex = 40;
            // 
            // lblEmailFormatWarning
            // 
            this.lblEmailFormatWarning.AutoSize = true;
            this.lblEmailFormatWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFormatWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmailFormatWarning.Location = new System.Drawing.Point(113, 181);
            this.lblEmailFormatWarning.Name = "lblEmailFormatWarning";
            this.lblEmailFormatWarning.Size = new System.Drawing.Size(134, 16);
            this.lblEmailFormatWarning.TabIndex = 40;
            this.lblEmailFormatWarning.Text = "Incorrect email format";
            this.lblEmailFormatWarning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(176)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Create an account";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(81, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtName.BorderRadius = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "Name";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(112, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(297, 38);
            this.txtName.TabIndex = 26;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "Email";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(114, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(297, 38);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 2;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "Phone";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(112, 203);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(297, 38);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(81, 38);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(85, 334);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 26);
            this.btnPreview.TabIndex = 23;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(25, 203);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(81, 38);
            this.label8.TabIndex = 35;
            this.label8.Text = "Phone";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1062, 52);
            this.pnlHeader.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Size = new System.Drawing.Size(288, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "MEHEDI MART LTD. | SALEMAN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(panel2);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 52);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1062, 583);
            this.pnlContainer.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(25, 263);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(81, 38);
            this.label7.TabIndex = 41;
            this.label7.Text = "Gender";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(126, 272);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(58, 20);
            this.guna2RadioButton1.TabIndex = 42;
            this.guna2RadioButton1.Text = "Male";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Location = new System.Drawing.Point(200, 272);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(74, 20);
            this.guna2RadioButton2.TabIndex = 43;
            this.guna2RadioButton2.Text = "Female";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "NID";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(112, 323);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(297, 38);
            this.guna2TextBox1.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(25, 323);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(81, 38);
            this.label9.TabIndex = 45;
            this.label9.Text = "NID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNID
            // 
            this.txtNID.Animated = true;
            this.txtNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtNID.BorderRadius = 2;
            this.txtNID.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtNID.BorderThickness = 0;
            this.txtNID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNID.DefaultText = "NID: ";
            this.txtNID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNID.ForeColor = System.Drawing.Color.Black;
            this.txtNID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNID.Location = new System.Drawing.Point(14, 359);
            this.txtNID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNID.Name = "txtNID";
            this.txtNID.PlaceholderText = "";
            this.txtNID.ReadOnly = true;
            this.txtNID.SelectedText = "";
            this.txtNID.Size = new System.Drawing.Size(240, 29);
            this.txtNID.TabIndex = 46;
            // 
            // FormFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1062, 635);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormFirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman Registration";
            panel2.ResumeLayout(false);
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutputProfie)).EndInit();
            this.pnlVarifyMsg.ResumeLayout(false);
            this.pnlVarifyMsg.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label labVerifyMsg;
        private System.Windows.Forms.Button btnPreview;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label lblSourceImagePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlVarifyMsg;
        private System.Windows.Forms.Panel pnlOutput;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputID;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputPassword;
        private System.Windows.Forms.PictureBox picOutputProfie;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblEmailFormatWarning;
        private System.Windows.Forms.Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtNID;
    }
}