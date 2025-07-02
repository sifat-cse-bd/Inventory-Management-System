namespace InventoryManagement.App
{
    partial class FormNewPasswordEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPasswordEntry));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewRePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlContainer.Controls.Add(this.btnClose);
            this.pnlContainer.Controls.Add(this.txtNewPassword);
            this.pnlContainer.Controls.Add(this.txtNewRePassword);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.labUsername);
            this.pnlContainer.Controls.Add(this.btnReset);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(498, 333);
            this.pnlContainer.TabIndex = 30;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.txtNewPassword.BorderRadius = 4;
            this.txtNewPassword.BorderThickness = 2;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(38, 77);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(411, 49);
            this.txtNewPassword.TabIndex = 16;
            // 
            // txtNewRePassword
            // 
            this.txtNewRePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.txtNewRePassword.BorderRadius = 4;
            this.txtNewRePassword.BorderThickness = 2;
            this.txtNewRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewRePassword.DefaultText = "";
            this.txtNewRePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewRePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewRePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewRePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewRePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.txtNewRePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewRePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewRePassword.Location = new System.Drawing.Point(38, 180);
            this.txtNewRePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewRePassword.Name = "txtNewRePassword";
            this.txtNewRePassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtNewRePassword.PlaceholderText = "Re-Enter New Password";
            this.txtNewRePassword.SelectedText = "";
            this.txtNewRePassword.Size = new System.Drawing.Size(411, 49);
            this.txtNewRePassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Re-New Password";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.BackColor = System.Drawing.Color.Transparent;
            this.labUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.White;
            this.labUsername.Location = new System.Drawing.Point(35, 51);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(131, 21);
            this.labUsername.TabIndex = 10;
            this.labUsername.Text = "New Password";
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
            this.btnReset.Location = new System.Drawing.Point(334, 248);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Change";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnClose.Location = new System.Drawing.Point(451, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 36);
            this.btnClose.TabIndex = 26;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormNewPasswordEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(498, 333);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewPasswordEntry";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewPassowrdEntry";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewRePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labUsername;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}