namespace InventoryManagement.Admin.Activity.Dashboard
{
    partial class PurchaseHistoryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseHistoryControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPurchaseHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblListStatus = new System.Windows.Forms.Label();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lblListStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.dgvPurchaseHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 687);
            this.panel1.TabIndex = 1;
            // 
            // dgvPurchaseHistory
            // 
            this.dgvPurchaseHistory.AllowUserToAddRows = false;
            this.dgvPurchaseHistory.AllowUserToDeleteRows = false;
            this.dgvPurchaseHistory.AllowUserToResizeColumns = false;
            this.dgvPurchaseHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgvPurchaseHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseHistory.ColumnHeadersHeight = 18;
            this.dgvPurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPurchaseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseID,
            this.Product,
            this.QTY,
            this.UnitPrice,
            this.Total,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvPurchaseHistory.Location = new System.Drawing.Point(15, 78);
            this.dgvPurchaseHistory.Margin = new System.Windows.Forms.Padding(15);
            this.dgvPurchaseHistory.Name = "dgvPurchaseHistory";
            this.dgvPurchaseHistory.ReadOnly = true;
            this.dgvPurchaseHistory.RowHeadersVisible = false;
            this.dgvPurchaseHistory.RowHeadersWidth = 51;
            this.dgvPurchaseHistory.RowTemplate.Height = 24;
            this.dgvPurchaseHistory.Size = new System.Drawing.Size(578, 594);
            this.dgvPurchaseHistory.TabIndex = 1;
            this.dgvPurchaseHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepOrange;
            this.dgvPurchaseHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgvPurchaseHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPurchaseHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPurchaseHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseHistory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.dgvPurchaseHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgvPurchaseHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(248)))));
            this.dgvPurchaseHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPurchaseHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPurchaseHistory.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvPurchaseHistory.ThemeStyle.ReadOnly = true;
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            this.dgvPurchaseHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.toolTip1.SetToolTip(this.dgvPurchaseHistory, "Purcase History");
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(497, 22);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(96, 29);
            this.guna2Button2.TabIndex = 29;
            this.guna2Button2.Text = "Print";
            this.toolTip1.SetToolTip(this.guna2Button2, "Print Purchase Report");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Purchase History";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(227, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(210, 19);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "January - February";
            // 
            // lblListStatus
            // 
            this.lblListStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListStatus.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListStatus.Location = new System.Drawing.Point(228, 352);
            this.lblListStatus.Name = "lblListStatus";
            this.lblListStatus.Size = new System.Drawing.Size(159, 31);
            this.lblListStatus.TabIndex = 32;
            this.lblListStatus.Text = "Empty list";
            this.lblListStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "Purchase_ID";
            this.PurchaseID.HeaderText = "Purchase ID";
            this.PurchaseID.MinimumWidth = 6;
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "P_Name";
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "Purchase_Quantity";
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "Purchase_UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Purchase_TotalPrice";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Purchase_Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PurchaseHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseHistoryControl";
            this.Size = new System.Drawing.Size(608, 687);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseHistory;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblListStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
