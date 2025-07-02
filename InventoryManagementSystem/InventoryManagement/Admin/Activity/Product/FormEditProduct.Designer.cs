namespace InventoryManagement.Admin.Activity.Product
{
    partial class FormEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlertQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductCode);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSellingPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAlertQuantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPurchasePrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 510);
            this.panel1.TabIndex = 43;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.SlateGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(147, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 34);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(37, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pcbProduct);
            this.panel3.Location = new System.Drawing.Point(235, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 80);
            this.panel3.TabIndex = 58;
            // 
            // pcbProduct
            // 
            this.pcbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbProduct.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pcbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbProduct.FillColor = System.Drawing.Color.Transparent;
            this.pcbProduct.ImageRotate = 0F;
            this.pcbProduct.Location = new System.Drawing.Point(3, 3);
            this.pcbProduct.Name = "pcbProduct";
            this.pcbProduct.Size = new System.Drawing.Size(143, 73);
            this.pcbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProduct.TabIndex = 26;
            this.pcbProduct.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(236, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 57;
            this.label7.Text = "Product Photo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.Location = new System.Drawing.Point(336, 421);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(50, 27);
            this.btnChoose.TabIndex = 55;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(37, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 73);
            this.label5.TabIndex = 53;
            this.label5.Text = "Category:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Update Product Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.DefaultText = "";
            this.txtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSellingPrice.ForeColor = System.Drawing.Color.Black;
            this.txtSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSellingPrice.IconRight")));
            this.txtSellingPrice.Location = new System.Drawing.Point(37, 249);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PlaceholderText = "Enter selling price";
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.Size = new System.Drawing.Size(349, 36);
            this.txtSellingPrice.TabIndex = 50;
            this.txtSellingPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSellingPrice_KeyDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(37, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 49;
            this.label8.Text = "Selling Price:";
            // 
            // txtAlertQuantity
            // 
            this.txtAlertQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlertQuantity.DefaultText = "";
            this.txtAlertQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlertQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlertQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlertQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlertQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlertQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtAlertQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtAlertQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlertQuantity.IconRight = ((System.Drawing.Image)(resources.GetObject("txtAlertQuantity.IconRight")));
            this.txtAlertQuantity.Location = new System.Drawing.Point(37, 332);
            this.txtAlertQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAlertQuantity.Name = "txtAlertQuantity";
            this.txtAlertQuantity.PlaceholderText = "Enter alert quantity";
            this.txtAlertQuantity.SelectedText = "";
            this.txtAlertQuantity.Size = new System.Drawing.Size(161, 36);
            this.txtAlertQuantity.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(37, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Alert quantity:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.DefaultText = "";
            this.txtPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.txtPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.IconRight = ((System.Drawing.Image)(resources.GetObject("txtPurchasePrice.IconRight")));
            this.txtPurchasePrice.Location = new System.Drawing.Point(37, 161);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderText = "Enter Price";
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.Size = new System.Drawing.Size(349, 36);
            this.txtPurchasePrice.TabIndex = 46;
            this.txtPurchasePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchasePrice_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "Purchase Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(37, 79);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "Enter Product Name";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(349, 36);
            this.txtProductName.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Product name:";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(375, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 53);
            this.panel2.TabIndex = 44;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Location = new System.Drawing.Point(37, 412);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(161, 36);
            this.cmbCategory.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(6, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 62;
            this.label9.Text = "Product Code:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductCode
            // 
            this.lblProductCode.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductCode.Location = new System.Drawing.Point(104, 12);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(147, 26);
            this.lblProductCode.TabIndex = 63;
            this.lblProductCode.Text = "null";
            this.lblProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(422, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopUpEditProduct";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSellingPrice;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAlertQuantity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox pcbProduct;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label label9;
    }
}