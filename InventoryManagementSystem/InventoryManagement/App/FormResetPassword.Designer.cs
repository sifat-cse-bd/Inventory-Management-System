namespace InventoryManagement.App
{
    partial class FormResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResetPassword));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lblShopName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.lblEmailStatus = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.pnlContainer);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblShopName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 513);
            this.panel2.TabIndex = 14;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.lblEmailStatus);
            this.pnlContainer.Controls.Add(this.lblUserStatus);
            this.pnlContainer.Controls.Add(this.txtUserID);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.labUsername);
            this.pnlContainer.Controls.Add(this.btnReset);
            this.pnlContainer.Location = new System.Drawing.Point(79, 132);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(490, 313);
            this.pnlContainer.TabIndex = 28;
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
            this.txtUserID.Location = new System.Drawing.Point(38, 61);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtUserID.PlaceholderText = "Enter User ID";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(411, 49);
            this.txtUserID.TabIndex = 16;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.txtEmail.BorderRadius = 4;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(38, 164);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtEmail.PlaceholderText = "User Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(411, 49);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.BackColor = System.Drawing.Color.Transparent;
            this.labUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.White;
            this.labUsername.Location = new System.Drawing.Point(35, 35);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(68, 21);
            this.labUsername.TabIndex = 10;
            this.labUsername.Text = "User ID";
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 4;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(1)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(334, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblShopName
            // 
            this.lblShopName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.ForeColor = System.Drawing.Color.White;
            this.lblShopName.Location = new System.Drawing.Point(228, 29);
            this.lblShopName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(202, 32);
            this.lblShopName.TabIndex = 17;
            this.lblShopName.Text = "MEHEDI MART LTD.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reset Your Password";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblUserStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.White;
            this.lblUserStatus.Location = new System.Drawing.Point(207, 115);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(236, 21);
            this.lblUserStatus.TabIndex = 17;
            this.lblUserStatus.Text = "N/A";
            this.lblUserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailStatus
            // 
            this.lblEmailStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailStatus.ForeColor = System.Drawing.Color.White;
            this.lblEmailStatus.Location = new System.Drawing.Point(207, 218);
            this.lblEmailStatus.Name = "lblEmailStatus";
            this.lblEmailStatus.Size = new System.Drawing.Size(236, 21);
            this.lblEmailStatus.TabIndex = 18;
            this.lblEmailStatus.Text = "N/A";
            this.lblEmailStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnClose.Location = new System.Drawing.Point(595, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 36);
            this.btnClose.TabIndex = 25;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(648, 513);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResetPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetPassword";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labUsername;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Label lblEmailStatus;
    }
}