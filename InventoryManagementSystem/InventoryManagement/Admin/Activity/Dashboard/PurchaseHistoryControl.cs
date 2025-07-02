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
    public partial class PurchaseHistoryControl : UserControl
    {
       private Database.DataAccess Da { get; set; }
        private string Query { get; set; }
        public PurchaseHistoryControl()
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.Query = @"select pc.Purchase_ID, p.P_Name, pc.Purchase_Quantity, pc.Purchase_UnitPrice, pc.Purchase_TotalPrice, pc.Purchase_Date

from Purchase pc, product p, ProductPurchase pp
where pc.Purchase_ID = pp.Purchase_ID  order by pc.Purchase_Date;";

            this.PopulateGridView();
        }

        internal void PopulateGridView(string sql = null, SqlParameter[] parameter = null)
        {
            if (string.IsNullOrEmpty(sql))
                sql = this.Query;

            try
            {
                DataSet ds = (parameter == null)
                    ? Da.ExecuteQuery(sql)
                    : Da.ExecuteQuery(sql, parameter);

                dgvPurchaseHistory.EnableHeadersVisualStyles = false;
                dgvPurchaseHistory.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvPurchaseHistory.ColumnHeadersDefaultCellStyle.BackColor;
                dgvPurchaseHistory.AutoGenerateColumns = false;

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvPurchaseHistory.DataSource = ds.Tables[0];
                    this.lblListStatus.Visible = false;
                }
                else
                {
                    dgvPurchaseHistory.DataSource = null;
                    this.lblListStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product data. Please try again.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
