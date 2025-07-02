
using System.Windows.Forms;
using System.Data;

namespace InventoryManagement.Admin.Activity
{
    partial class AddProductControl : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductControl));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSellingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtAlertQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.txtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttCatAdd = new MetroFramework.Components.MetroToolTip();
            this.pnlContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.cmbCategory);
            this.pnlContainer.Controls.Add(this.txtSellingPrice);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.lblFileName);
            this.pnlContainer.Controls.Add(this.txtAlertQuantity);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.btnChoose);
            this.pnlContainer.Controls.Add(this.txtPurchasePrice);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.txtProductName);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Location = new System.Drawing.Point(20, 73);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(877, 370);
            this.pnlContainer.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbProduct);
            this.panel1.Location = new System.Drawing.Point(572, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 177);
            this.panel1.TabIndex = 28;
            // 
            // pcbProduct
            // 
            this.pcbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbProduct.BackgroundImage")));
            this.pcbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbProduct.FillColor = System.Drawing.Color.Transparent;
            this.pcbProduct.ImageRotate = 0F;
            this.pcbProduct.Location = new System.Drawing.Point(15, 15);
            this.pcbProduct.Name = "pcbProduct";
            this.pcbProduct.Size = new System.Drawing.Size(240, 145);
            this.pcbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProduct.TabIndex = 26;
            this.pcbProduct.TabStop = false;
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
            this.cmbCategory.Location = new System.Drawing.Point(499, 48);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(345, 36);
            this.cmbCategory.TabIndex = 25;
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
            this.txtSellingPrice.Location = new System.Drawing.Point(37, 221);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PlaceholderText = "0.00";
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.Size = new System.Drawing.Size(344, 36);
            this.txtSellingPrice.TabIndex = 24;
            this.txtSellingPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSellingPrice_KeyDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(37, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Selling Price:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(568, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product Photo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName.Location = new System.Drawing.Point(700, 322);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(172, 34);
            this.lblFileName.TabIndex = 21;
            this.lblFileName.Text = "No file choosen";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtAlertQuantity.Location = new System.Drawing.Point(37, 303);
            this.txtAlertQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAlertQuantity.Name = "txtAlertQuantity";
            this.txtAlertQuantity.PlaceholderText = "Enter alert quantity";
            this.txtAlertQuantity.SelectedText = "";
            this.txtAlertQuantity.Size = new System.Drawing.Size(344, 36);
            this.txtAlertQuantity.TabIndex = 20;
            this.txtAlertQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlertQuantity_KeyDown);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(37, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Alert quantity:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(499, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Category:";
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.Location = new System.Drawing.Point(572, 322);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(122, 34);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Choose File";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
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
            this.txtPurchasePrice.Location = new System.Drawing.Point(37, 133);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderText = "0.00";
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.Size = new System.Drawing.Size(344, 36);
            this.txtPurchasePrice.TabIndex = 16;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            this.txtPurchasePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchasePrice_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 15;
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
            this.txtProductName.Location = new System.Drawing.Point(37, 48);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "Enter Product Name";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(344, 36);
            this.txtProductName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(8)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(784, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add new Product";
            // 
            // ttCatAdd
            // 
            this.ttCatAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttCatAdd.StyleManager = null;
            this.ttCatAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // AddProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "AddProductControl";
            this.Size = new System.Drawing.Size(918, 594);
            this.pnlContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAlertQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSellingPrice;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2PictureBox pcbProduct;
        private MetroFramework.Components.MetroToolTip ttCatAdd;
        private System.Windows.Forms.Panel panel1;
    }
}
