using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity.Dashboard
{
    public partial class FormSaleDetails : Form
    {
        private Database.DataAccess Da {  get; set; }
        private string Discount { get; set; }
        private string InvoiceNo { get; set; }
        public FormSaleDetails(string invoice, string issueDate, string totalDiscount, string recievedAmount, string returnedAmount)
        {
            InitializeComponent();
            this.Discount = totalDiscount;
            this.InvoiceNo = invoice;
            this.lblDate.Text = issueDate;
            this.lblInvoiceNo.Text = invoice;
            this.lblRecievedAmount.Text = recievedAmount;
            this.lblReturnedAmount.Text = returnedAmount;
            this.Da = new Database.DataAccess();
            this.populateGridView();
        }

        private void populateGridView(string sql = null)
        {
            if (sql == null)
            {
                sql = @"SELECT 
                            p.P_ID, 
                            p.P_Name, 
                            bs.Sale_Quantity, 
                            Format(bs.Sale_UnitPrice, 'N2') as Sale_UnitPrice, 
                            Format(bs.Sale_SubTotal, 'N2') as Sale_SubTotal
                        FROM billSale bs
                        LEFT JOIN ProductSale ps ON bs.Sale_ID = ps.Sale_ID
                        LEFT JOIN Product p ON p.P_ID = ps.P_ID

                        WHERE bs.InvoiceNo = @invoiceNo;";
            }
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter(@"invoiceNo", this.InvoiceNo)
            };

            var dt = this.Da.ExecuteQueryTable(sql, para);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Database returned empty table");
                return;
            }

            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.DataSource = dt;
            this.SubTotal();
            this.NetTotal();
        }

        private decimal total = 0;

        private void SubTotal()
        {
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            this.lblSubTotal.Text = total.ToString("N2");
        }

        private void NetTotal()
        {
            try
            {
                decimal discount = 0;
                decimal.TryParse(this.Discount, out discount);

                decimal netTotal = total - discount;
                this.lblNetTotal.Text = netTotal.ToString("N2");
            }
            catch 
            {
                MessageBox.Show("Error Calculating Net Total");
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
