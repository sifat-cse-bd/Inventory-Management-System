namespace InventoryManagement.Admin.Activity.Dashboard
{
    partial class FormSaleDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.dgvInvoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblReturnedAmount = new System.Windows.Forms.Label();
            this.lblRecievedAmount = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvInvoice);
            this.panel2.Controls.Add(this.lblInvoiceNo);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 666);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblReturnedAmount);
            this.panel3.Controls.Add(this.lblRecievedAmount);
            this.panel3.Controls.Add(this.lblReturn);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lblNetTotal);
            this.panel3.Controls.Add(this.lblDiscount);
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 194);
            this.panel3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 26);
            this.label10.TabIndex = 46;
            this.label10.Text = "Sales Information";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(258, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mehedi Mart LTD.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblDate.Location = new System.Drawing.Point(12, 88);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(256, 26);
            this.lblDate.TabIndex = 48;
            this.lblDate.Text = "Date: ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(12, 111);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(256, 26);
            this.lblInvoiceNo.TabIndex = 49;
            this.lblInvoiceNo.Text = "Invoice No: ";
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Item,
            this.QTY,
            this.MRP,
            this.Total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvInvoice.Location = new System.Drawing.Point(12, 143);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(673, 314);
            this.dgvInvoice.TabIndex = 50;
            this.dgvInvoice.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInvoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvInvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dgvInvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvInvoice.ThemeStyle.ReadOnly = true;
            this.dgvInvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvInvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInvoice.ThemeStyle.RowsStyle.Height = 24;
            this.dgvInvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvInvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(277, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Discount (-)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(277, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 26);
            this.label5.TabIndex = 50;
            this.label5.Text = "Sub Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(277, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "Net Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetTotal.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblNetTotal.Location = new System.Drawing.Point(434, 77);
            this.lblNetTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(250, 26);
            this.lblNetTotal.TabIndex = 55;
            this.lblNetTotal.Text = "0.00";
            this.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblDiscount.Location = new System.Drawing.Point(434, 48);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(250, 26);
            this.lblDiscount.TabIndex = 54;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblSubTotal.Location = new System.Drawing.Point(434, 19);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(250, 26);
            this.lblSubTotal.TabIndex = 53;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReturnedAmount
            // 
            this.lblReturnedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnedAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblReturnedAmount.Location = new System.Drawing.Point(434, 142);
            this.lblReturnedAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnedAmount.Name = "lblReturnedAmount";
            this.lblReturnedAmount.Size = new System.Drawing.Size(250, 26);
            this.lblReturnedAmount.TabIndex = 59;
            this.lblReturnedAmount.Text = "0.00";
            this.lblReturnedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecievedAmount
            // 
            this.lblRecievedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecievedAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblRecievedAmount.Location = new System.Drawing.Point(434, 113);
            this.lblRecievedAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecievedAmount.Name = "lblRecievedAmount";
            this.lblRecievedAmount.Size = new System.Drawing.Size(250, 26);
            this.lblRecievedAmount.TabIndex = 58;
            this.lblRecievedAmount.Text = "0.00";
            this.lblRecievedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReturn
            // 
            this.lblReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lblReturn.Location = new System.Drawing.Point(277, 142);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(153, 26);
            this.lblReturn.TabIndex = 57;
            this.lblReturn.Text = "Return Amount";
            this.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label14.Location = new System.Drawing.Point(277, 113);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 26);
            this.label14.TabIndex = 56;
            this.label14.Text = "Received Amount";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(277, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Net Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.btnClose.Location = new System.Drawing.Point(635, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 38);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Code.DataPropertyName = "P_ID";
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 120;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "P_Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Item.DefaultCellStyle = dataGridViewCellStyle3;
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QTY.DataPropertyName = "Sale_Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QTY.DefaultCellStyle = dataGridViewCellStyle4;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 60;
            // 
            // MRP
            // 
            this.MRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MRP.DataPropertyName = "Sale_UnitPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MRP.DefaultCellStyle = dataGridViewCellStyle5;
            this.MRP.HeaderText = "MRP";
            this.MRP.MinimumWidth = 6;
            this.MRP.Name = "MRP";
            this.MRP.ReadOnly = true;
            this.MRP.Width = 120;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.DataPropertyName = "Sale_SubTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // FormSaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(697, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSaleDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSaleDetails";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvoiceNo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReturnedAmount;
        private System.Windows.Forms.Label lblRecievedAmount;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}