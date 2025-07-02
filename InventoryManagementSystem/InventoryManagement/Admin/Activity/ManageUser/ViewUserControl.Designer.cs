namespace InventoryManagement.Admin.Activity.ManageUser
{
    partial class ViewUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalesman = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserFoundStatus = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UserPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUserInfoContainer = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "All User";
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(252, 16);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(96, 34);
            this.btnAll.TabIndex = 18;
            this.btnAll.Text = "All";
            this.toolTip1.SetToolTip(this.btnAll, "Show All Users");
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(16, 16);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(96, 34);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "Admin";
            this.toolTip1.SetToolTip(this.btnAdmin, "Show All Admin");
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalesman
            // 
            this.btnSalesman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesman.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesman.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalesman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalesman.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnSalesman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalesman.ForeColor = System.Drawing.Color.White;
            this.btnSalesman.Location = new System.Drawing.Point(124, 16);
            this.btnSalesman.Name = "btnSalesman";
            this.btnSalesman.Size = new System.Drawing.Size(116, 34);
            this.btnSalesman.TabIndex = 16;
            this.btnSalesman.Text = "Salesman";
            this.toolTip1.SetToolTip(this.btnSalesman, "Show Salesman");
            this.btnSalesman.Click += new System.EventHandler(this.btnSalesman_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(278, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear");
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(23, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 25);
            this.btnDelete.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete User");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 483);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 477);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblUserFoundStatus);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 327);
            this.panel1.TabIndex = 0;
            // 
            // lblUserFoundStatus
            // 
            this.lblUserFoundStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserFoundStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.lblUserFoundStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFoundStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserFoundStatus.Location = new System.Drawing.Point(126, 192);
            this.lblUserFoundStatus.Name = "lblUserFoundStatus";
            this.lblUserFoundStatus.Size = new System.Drawing.Size(127, 30);
            this.lblUserFoundStatus.TabIndex = 5;
            this.lblUserFoundStatus.Text = "No User Found!";
            this.lblUserFoundStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserFoundStatus.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(11, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Seach by name / ID";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(255, 33);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.ColumnHeadersHeight = 18;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserPhoto,
            this.UserID,
            this.UserName,
            this.UserRole});
            this.dgvUser.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvUser.Location = new System.Drawing.Point(11, 73);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(248)))));
            this.dgvUser.RowTemplate.Height = 60;
            this.dgvUser.Size = new System.Drawing.Size(342, 241);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepOrange;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUser.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.dgvUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.dgvUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUser.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvUser.ThemeStyle.ReadOnly = true;
            this.dgvUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.dgvUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUser.ThemeStyle.RowsStyle.Height = 60;
            this.dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            this.dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUser_CellFormatting);
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // UserPhoto
            // 
            this.UserPhoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserPhoto.DataPropertyName = "U_Photo";
            this.UserPhoto.HeaderText = "";
            this.UserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("UserPhoto.Image")));
            this.UserPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UserPhoto.MinimumWidth = 6;
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.ReadOnly = true;
            this.UserPhoto.ToolTipText = "Profile Photo";
            this.UserPhoto.Width = 50;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserID.DataPropertyName = "U_ID";
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 90;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "U_Name";
            this.UserName.HeaderText = "Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserRole
            // 
            this.UserRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserRole.DataPropertyName = "U_Role";
            this.UserRole.HeaderText = "Role";
            this.UserRole.MinimumWidth = 6;
            this.UserRole.Name = "UserRole";
            this.UserRole.ReadOnly = true;
            this.UserRole.Width = 70;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.pnlModify);
            this.panel4.Location = new System.Drawing.Point(3, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 56);
            this.panel4.TabIndex = 23;
            // 
            // pnlModify
            // 
            this.pnlModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(82)))));
            this.pnlModify.Controls.Add(this.btnDelete);
            this.pnlModify.Location = new System.Drawing.Point(278, 5);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(80, 47);
            this.pnlModify.TabIndex = 20;
            this.pnlModify.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.btnSalesman);
            this.panel3.Controls.Add(this.btnAdmin);
            this.panel3.Controls.Add(this.btnAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 64);
            this.panel3.TabIndex = 22;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.DataPropertyName = "U_Photo";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Profile Photo";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlUserInfoContainer);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(378, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 477);
            this.panel2.TabIndex = 26;
            // 
            // pnlUserInfoContainer
            // 
            this.pnlUserInfoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlUserInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserInfoContainer.Location = new System.Drawing.Point(0, 79);
            this.pnlUserInfoContainer.Name = "pnlUserInfoContainer";
            this.pnlUserInfoContainer.Size = new System.Drawing.Size(480, 398);
            this.pnlUserInfoContainer.TabIndex = 22;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(480, 79);
            this.guna2Panel1.TabIndex = 23;
            // 
            // ViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ViewUserControl";
            this.Size = new System.Drawing.Size(918, 594);
            this.Load += new System.EventHandler(this.ViewUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlModify.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSalesman;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlModify;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewImageColumn UserPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserFoundStatus;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel pnlUserInfoContainer;
    }
}
