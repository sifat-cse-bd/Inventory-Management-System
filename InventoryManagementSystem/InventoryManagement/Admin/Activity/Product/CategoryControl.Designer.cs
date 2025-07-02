namespace InventoryManagement.Admin.Activity.Product
{
    partial class CategoryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCatID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lblCatFoundStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lblCatFoundStatus);
            this.panel1.Controls.Add(this.dgvCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 209);
            this.panel1.TabIndex = 0;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatID,
            this.categoryName,
            this.description});
            this.dgvCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(918, 209);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.DoubleClick += new System.EventHandler(this.dgvCategory_DoubleClick);
            // 
            // CatID
            // 
            this.CatID.DataPropertyName = "Cat_ID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.CatID.DefaultCellStyle = dataGridViewCellStyle1;
            this.CatID.HeaderText = "Category ID";
            this.CatID.MinimumWidth = 6;
            this.CatID.Name = "CatID";
            this.CatID.ReadOnly = true;
            this.CatID.ToolTipText = "Category ID";
            this.CatID.Width = 125;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "Cat_Name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.categoryName.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 200;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "Cat_Description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.description.DefaultCellStyle = dataGridViewCellStyle3;
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BorderRadius = 10;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(789, 271);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(117, 34);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(494, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(251, 260);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 31);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 64);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtSearchBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(489, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 64);
            this.panel5.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(8)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(348, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Location = new System.Drawing.Point(74, 13);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 6, 0, 6);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PlaceholderText = "Search by category";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(274, 31);
            this.txtSearchBox.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.txtSearchBox, "Search by Category Name");
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add new Categroy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.btnShowAll);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.txtCatID);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtCategoryName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 321);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(332, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Category ID";
            // 
            // txtCatID
            // 
            this.txtCatID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCatID.DefaultText = "";
            this.txtCatID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCatID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCatID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCatID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCatID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCatID.ForeColor = System.Drawing.Color.Black;
            this.txtCatID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatID.Location = new System.Drawing.Point(335, 37);
            this.txtCatID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.PlaceholderText = "";
            this.txtCatID.ReadOnly = true;
            this.txtCatID.SelectedText = "";
            this.txtCatID.Size = new System.Drawing.Size(253, 30);
            this.txtCatID.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(380, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 31);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category Description (Optional)";
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(34, 105);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(554, 131);
            this.txtDescription.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(31, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.DefaultText = "";
            this.txtCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryName.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Location = new System.Drawing.Point(34, 37);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PlaceholderText = "";
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(253, 30);
            this.txtCategoryName.TabIndex = 15;
            this.txtCategoryName.Leave += new System.EventHandler(this.txtCategroyName_Leave);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblCatFoundStatus
            // 
            this.lblCatFoundStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.lblCatFoundStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatFoundStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCatFoundStatus.Location = new System.Drawing.Point(393, 103);
            this.lblCatFoundStatus.Name = "lblCatFoundStatus";
            this.lblCatFoundStatus.Size = new System.Drawing.Size(163, 31);
            this.lblCatFoundStatus.TabIndex = 10;
            this.lblCatFoundStatus.Text = "No category found!";
            this.lblCatFoundStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCatFoundStatus.Visible = false;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(918, 594);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnShowAll;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtCatID;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label lblCatFoundStatus;
    }
}
