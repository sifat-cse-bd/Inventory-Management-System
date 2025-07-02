namespace InventoryManagement.Admin.Activity
{
    partial class ListProductControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProductControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.dgvProductList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmsProduct = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.btnAddDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbFilter = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.addDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.cmsProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductStatus);
            this.panel1.Controls.Add(this.dgvProductList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 494);
            this.panel1.TabIndex = 0;
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductStatus.Location = new System.Drawing.Point(342, 236);
            this.lblProductStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(216, 31);
            this.lblProductStatus.TabIndex = 3;
            this.lblProductStatus.Text = "No Product Available";
            this.lblProductStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductStatus.Visible = false;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.ColumnHeadersHeight = 40;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.Photo,
            this.Product,
            this.StockQuantity,
            this.PurchasingPrice,
            this.SellingPrice,
            this.Category,
            this.AlertQuantity,
            this.Discount,
            this.Purchase});
            this.dgvProductList.ContextMenuStrip = this.cmsProduct;
            this.dgvProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgvProductList.Location = new System.Drawing.Point(20, 0);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductList.RowTemplate.ContextMenuStrip = this.cmsProduct;
            this.dgvProductList.RowTemplate.Height = 45;
            this.dgvProductList.Size = new System.Drawing.Size(880, 479);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.dgvProductList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgvProductList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.dgvProductList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProductList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProductList.ThemeStyle.ReadOnly = true;
            this.dgvProductList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dgvProductList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductList.ThemeStyle.RowsStyle.Height = 45;
            this.dgvProductList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dgvProductList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            this.dgvProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductList_CellFormatting);
            this.dgvProductList.DoubleClick += new System.EventHandler(this.dgvProductList_DoubleClick);
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductCode.DataPropertyName = "P_ID";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.MinimumWidth = 115;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductCode.Width = 115;
            // 
            // Photo
            // 
            this.Photo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Photo.DataPropertyName = "P_Image";
            this.Photo.HeaderText = "Photo";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Photo.MinimumWidth = 60;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Photo.Width = 60;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "P_Name";
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 150;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StockQuantity
            // 
            this.StockQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StockQuantity.DataPropertyName = "P_StockQuantity";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockQuantity.HeaderText = "Stock Quantity";
            this.StockQuantity.MinimumWidth = 6;
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.ReadOnly = true;
            this.StockQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StockQuantity.Width = 70;
            // 
            // PurchasingPrice
            // 
            this.PurchasingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PurchasingPrice.DataPropertyName = "P_PurchasingPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchasingPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.PurchasingPrice.HeaderText = "Purchasing Price";
            this.PurchasingPrice.MinimumWidth = 6;
            this.PurchasingPrice.Name = "PurchasingPrice";
            this.PurchasingPrice.ReadOnly = true;
            this.PurchasingPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchasingPrice.Width = 120;
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SellingPrice.DataPropertyName = "P_SellingPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SellingPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.MinimumWidth = 6;
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            this.SellingPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SellingPrice.Width = 120;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Category.DataPropertyName = "Categories";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.DefaultCellStyle = dataGridViewCellStyle6;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.Width = 115;
            // 
            // AlertQuantity
            // 
            this.AlertQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AlertQuantity.DataPropertyName = "P_AlertQuantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AlertQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.AlertQuantity.HeaderText = "Alert Quantity";
            this.AlertQuantity.MinimumWidth = 6;
            this.AlertQuantity.Name = "AlertQuantity";
            this.AlertQuantity.ReadOnly = true;
            this.AlertQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlertQuantity.Width = 60;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Discount.DataPropertyName = "Discount_Value";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle8;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 50;
            // 
            // Purchase
            // 
            this.Purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            this.Purchase.DefaultCellStyle = dataGridViewCellStyle9;
            this.Purchase.HeaderText = "Purchase";
            this.Purchase.MinimumWidth = 6;
            this.Purchase.Name = "Purchase";
            this.Purchase.ReadOnly = true;
            this.Purchase.Text = "Buy";
            this.Purchase.UseColumnTextForButtonValue = true;
            this.Purchase.Width = 80;
            // 
            // cmsProduct
            // 
            this.cmsProduct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.addDiscountToolStripMenuItem});
            this.cmsProduct.Name = "cmsProduct";
            this.cmsProduct.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsProduct.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsProduct.RenderStyle.ColorTable = null;
            this.cmsProduct.RenderStyle.RoundedEdges = true;
            this.cmsProduct.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsProduct.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsProduct.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsProduct.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsProduct.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsProduct.Size = new System.Drawing.Size(211, 128);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewToolStripMenuItem.Text = "Remove Discount";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product List";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(87, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 6, 0, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by product name or code";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(81, 31);
            this.txtSearch.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.txtSearch, "Search Product");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(380, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 54);
            this.panel2.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(8)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(168, 13);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(51, 31);
            this.guna2Button1.TabIndex = 6;
            this.metroToolTip1.SetToolTip(this.guna2Button1, "Search");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlModify);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 100);
            this.panel3.TabIndex = 5;
            // 
            // pnlModify
            // 
            this.pnlModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
            this.pnlModify.Controls.Add(this.btnAddDiscount);
            this.pnlModify.Controls.Add(this.btnEdit);
            this.pnlModify.Controls.Add(this.btnDelete);
            this.pnlModify.Location = new System.Drawing.Point(20, 44);
            this.pnlModify.Margin = new System.Windows.Forms.Padding(2);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(202, 48);
            this.pnlModify.TabIndex = 21;
            this.pnlModify.Visible = false;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.btnAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDiscount.FillColor = System.Drawing.Color.White;
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDiscount.ForeColor = System.Drawing.Color.White;
            this.btnAddDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDiscount.Image")));
            this.btnAddDiscount.Location = new System.Drawing.Point(14, 10);
            this.btnAddDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(36, 25);
            this.btnAddDiscount.TabIndex = 21;
            this.metroToolTip1.SetToolTip(this.btnAddDiscount, "Add Discount");
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(79, 10);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 25);
            this.btnEdit.TabIndex = 20;
            this.metroToolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(144, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 25);
            this.btnDelete.TabIndex = 19;
            this.metroToolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(252, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 58);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.cmbCategory);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(191, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 54);
            this.panel5.TabIndex = 7;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 24;
            this.cmbCategory.Location = new System.Drawing.Point(79, 15);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(90, 30);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.UseSelectable = true;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.cmbFilter);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 54);
            this.panel4.TabIndex = 5;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 24;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Stock In",
            "Stock Out",
            "Low Stock",
            "High Stock",
            "Discounted",
            "No Discount"});
            this.cmbFilter.Location = new System.Drawing.Point(60, 15);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(103, 30);
            this.cmbFilter.TabIndex = 6;
            this.cmbFilter.UseSelectable = true;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter by";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // addDiscountToolStripMenuItem
            // 
            this.addDiscountToolStripMenuItem.Name = "addDiscountToolStripMenuItem";
            this.addDiscountToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addDiscountToolStripMenuItem.Text = "Add Discount";
            // 
            // ListProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListProductControl";
            this.Size = new System.Drawing.Size(918, 594);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.cmsProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlModify.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsProduct;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductList;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.Panel pnlModify;
        private Guna.UI2.WinForms.Guna2Button btnAddDiscount;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewButtonColumn Purchase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroComboBox cmbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem addDiscountToolStripMenuItem;
    }
}
