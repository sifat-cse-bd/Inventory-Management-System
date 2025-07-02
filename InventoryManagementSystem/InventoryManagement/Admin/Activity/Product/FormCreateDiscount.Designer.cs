namespace InventoryManagement.Admin.Activity.Product
{
    partial class FormCreateDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateDiscount));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDiscountID = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDiscountType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblDiscountID);
            this.panel2.Controls.Add(this.lblSuffix);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbDiscountType);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 431);
            this.panel2.TabIndex = 91;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.lblStatus.Location = new System.Drawing.Point(42, 352);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(205, 20);
            this.lblStatus.TabIndex = 106;
            this.lblStatus.Text = "Existing discount";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Visible = false;
            // 
            // lblDiscountID
            // 
            this.lblDiscountID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDiscountID.Location = new System.Drawing.Point(12, 169);
            this.lblDiscountID.Name = "lblDiscountID";
            this.lblDiscountID.Size = new System.Drawing.Size(304, 20);
            this.lblDiscountID.TabIndex = 105;
            this.lblDiscountID.Text = "Discount ID:  ";
            this.lblDiscountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSuffix
            // 
            this.lblSuffix.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSuffix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuffix.Location = new System.Drawing.Point(322, 311);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(48, 36);
            this.lblSuffix.TabIndex = 104;
            this.lblSuffix.Text = "..";
            this.lblSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.Location = new System.Drawing.Point(336, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            this.btnClose.TabIndex = 103;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(33, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 20);
            this.label10.TabIndex = 102;
            this.label10.Text = "Discount Value";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(33, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Discount Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDiscountType
            // 
            this.cmbDiscountType.AutoRoundedCorners = true;
            this.cmbDiscountType.BackColor = System.Drawing.Color.Transparent;
            this.cmbDiscountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscountType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDiscountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDiscountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiscountType.ForeColor = System.Drawing.Color.Black;
            this.cmbDiscountType.ItemHeight = 30;
            this.cmbDiscountType.Items.AddRange(new object[] {
            "Fixed Amount",
            "Percentage "});
            this.cmbDiscountType.Location = new System.Drawing.Point(33, 230);
            this.cmbDiscountType.Name = "cmbDiscountType";
            this.cmbDiscountType.Size = new System.Drawing.Size(283, 36);
            this.cmbDiscountType.TabIndex = 100;
            this.cmbDiscountType.SelectedIndexChanged += new System.EventHandler(this.cmbDiscountType_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoRoundedCorners = true;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.Teal;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(242, 366);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 34);
            this.btnCreate.TabIndex = 99;
            this.btnCreate.Text = "create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(105, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(182, 105);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 92;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoRoundedCorners = true;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Location = new System.Drawing.Point(33, 311);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PlaceholderText = "Enter Discount";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(283, 36);
            this.txtDiscount.TabIndex = 88;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 66);
            this.label1.TabIndex = 91;
            this.label1.Text = "Create discount to the list ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(382, 431);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateDiscount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateDiscount";
            this.Load += new System.EventHandler(this.FormCreateDiscount_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDiscountType;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblDiscountID;
        private System.Windows.Forms.Label lblStatus;
    }
}