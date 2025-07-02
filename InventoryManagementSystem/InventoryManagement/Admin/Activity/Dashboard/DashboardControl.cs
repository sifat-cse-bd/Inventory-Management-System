using InventoryManagement.Admin.Activity.Dashboard;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace InventoryManagement.Admin.Activity
{
    public partial class UserControlAdminDashboard : UserControl
    {
        Database.DataAccess Da {  get; set; }
        private string FromDate { get; set; }
        private string ToDate { get; set; }
        private string DayBetween { get; set; }
        public UserControlAdminDashboard()
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.TotalSale();
            this.TotalPurchase();
            this.TotalProfit();
            //this.PopulateNotificationView();
            this.PopulateSaleGridView();
            this.PopulatePurchaseGridView();
        }

        private void UserControlAdminDashboard_Load(object sender, EventArgs e)
        {
        }


        private void PopulateSaleGridView(string sql = null)
        {
            try
            {
                if (sql == null)
                {
                    sql = @"SELECT 
                            b.TotalDiscount, b.IssueDate, b.ReceivedAmount, b.ReturnedAmount,
                            bs.InvoiceNO, 
                            N'৳' + FORMAT(SUM(bs.Sale_SubTotal), 'N2') AS Total, 
                            sb.S_ID, 
                            u.U_Name 
                        FROM BillSale bs
                        JOIN Bill b ON b.InvoiceNo = bs.InvoiceNo
                        JOIN SalesmanBill sb ON sb.InvoiceNo = b.InvoiceNo
                        LEFT JOIN Users u ON u.U_ID = sb.S_ID
                        GROUP BY 
                            bs.InvoiceNO, 
                            b.IssueDate,
                            b.TotalDiscount, b.ReceivedAmount, b.ReturnedAmount,
                            sb.S_ID, 
                            u.U_Name;";
                }

                var dt = Da.ExecuteQueryTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dgvSalesDetail.AutoGenerateColumns = false;
                    this.dgvSalesDetail.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Saling Data Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PopulatePurchaseGridView(string sql = null)
        {
            try
            {
                if (sql == null)
                {
                    sql = @"SELECT 
                            pc.Purchase_ID, 
                            pc.Purchase_TotalPrice, 
                            pc.Purchase_Quantity, pc.Purchase_Date,
                            p.P_Name  
                        FROM purchase pc
                        INNEr JOIN ProductPurchase pp ON pc.Purchase_ID = pp.Purchase_ID
                        inner JOIN Product p ON pp.P_ID = p.P_ID
                        GROUP BY 
                            pc.Purchase_ID, 
                            pc.Purchase_TotalPrice, 
                            pc.Purchase_Quantity, 
	                        pc.Purchase_Date,
                            p.P_Name;";
                }

                var dt = Da.ExecuteQueryTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dgvPurchaseDetail.AutoGenerateColumns = false;
                    this.dgvPurchaseDetail.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Purchaing Data Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void TotalSale(string sql = null)
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    this.lblSalesStatus.Text = "Sales of last 28 days";
                    sql = @"SELECT CONCAT(N'৳ ', FORMAT(SUM(sale_subtotal), 'N2')) AS TotalSale
                    FROM billSale bs
                    INNER JOIN bILL b ON b.InvoiceNo = bs.InvoiceNo
                    WHERE b.IssueDate >= DATEADD(DAY, -28, GETDATE());";
                }

                var dt = Da.ExecuteQueryTable(sql);
                lblTotalSale.Text = (dt != null && dt.Rows.Count > 0) ? dt.Rows[0][0].ToString() : "৳ 0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total sale: " + ex.Message);
            }
        }

        private void TotalPurchase(string sql = null)
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    this.lblPurchaseStatus.Text = "Purchases of last 28 days";

                    sql = @"SELECT CONCAT(N'৳ ', FORMAT(SUM(Purchase_totalprice), 'N2')) AS TotalPurchase
                    FROM purchase
                    WHERE Purchase_Date >= DATEADD(DAY, -28, GETDATE());";
                }

                var dt = Da.ExecuteQueryTable(sql);
                lblTotalPurchase.Text = (dt != null && dt.Rows.Count > 0) ? dt.Rows[0][0].ToString() : "৳ 0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total purchase: " + ex.Message);
            }
        }

        private void TotalProfit(string status = "Profits of last 28 days")
        {
            try
            {
                this.lblProfitStatus.Text = status;
                string purchaseText = lblTotalPurchase.Text.Replace("৳", "").Replace(",", "").Trim();
                string saleText = lblTotalSale.Text.Replace("৳", "").Replace(",", "").Trim();

                double totalpurchase = double.TryParse(purchaseText, out var p) ? p : 0;
                double totalsale = double.TryParse(saleText, out var s) ? s : 0;

                double profit = totalsale - totalpurchase;
                lblTotalProfit.Text = "৳ " + profit.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating profit: " + ex.Message);
            }
        }


       

        private bool IsValidDateDuration()
        {
            
            var duration = (dtpFrom.Value) - (dtpTo.Value);
            this.DayBetween = (Math.Abs(duration.Days)).ToString();

            this.FromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
            this.ToDate = dtpTo.Value.ToString("yyyy-MM-dd");

            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("From Date must be less than or equal to To Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        
        private void CustomDurationTotalSale()
        {
            lblSalesStatus.Text = "Total sales of " + this.DayBetween + " days";
            
            string sql = $@"SELECT ROUND(SUM(sale_subtotal), 2)
                            FROM billSale bs
                            INNER JOIN bILL b ON b.InvoiceNo = bs.InvoiceNo
                            WHERE CAST(b.IssueDate AS DATE) BETWEEN '{this.FromDate}' AND '{this.ToDate}'";


            this.TotalSale(sql);
        }


        private void CustomDurationTotalPurchase()
        {
            this.lblPurchaseStatus.Text = "Total Purchase of " + this.DayBetween + " days";

            string sql = $@"SELECT CONCAT(N'৳ ', FORMAT(SUM(Purchase_totalprice), 'N2')) AS TotalPurchase
                            FROM purchase
                            WHERE CAST(Purchase_Date AS DATE) BETWEEN '{this.FromDate}' AND '{this.ToDate}'";


            this.TotalPurchase(sql);
        }

        private void CustomDurationTotalProfit()
        {
            var status =  "Total Profits of " + this.DayBetween + " days";
            this.TotalProfit(status);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!IsValidDateDuration()) return;

            this.CustomDurationTotalSale();
            this.CustomDurationTotalPurchase();
            this.CustomDurationTotalProfit();
        }
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            this.TotalProfit();
            this.TotalPurchase();
            this.TotalSale();
        }


        //Notification 
        //internal void PopulateNotificationView(SqlParameter[] parameter = null, string sql = null)
        //{
        //    if (string.IsNullOrEmpty(sql))
        //        sql = @"select P_Name, P_StockQuantity from Product
        //                where P_StockQuantity <= P_AlertQuantity;";

        //    try
        //    {
        //        DataSet ds = (parameter == null)
        //            ? Da.ExecuteQuery(sql)
        //            : Da.ExecuteQuery(sql, parameter);

        //        this.dgvNotification.EnableHeadersVisualStyles = false;
        //        this.dgvNotification.ColumnHeadersDefaultCellStyle.SelectionBackColor = this.dgvNotification.ColumnHeadersDefaultCellStyle.BackColor;
        //        this.dgvNotification.AutoGenerateColumns = false;

        //        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //        {
        //            this.dgvNotification.DataSource = ds.Tables[0];
        //            //this.dgvNotification.Visible = false;
        //        }
        //        else
        //        {
        //            this.dgvNotification.DataSource = null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error fetching product data. Please try again.\n\n" + ex.Message,
        //                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void dgvNotification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            //{
            //    var pCode = this.dgvNotification.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
            //    var pName = this.dgvNotification.Rows[e.RowIndex].Cells["Product"].Value.ToString();
            //    var pStock = this.dgvNotification.Rows[e.RowIndex].Cells["StockQuantity"].Value.ToString();
            //    var pPrice = this.dgvNotification.Rows[e.RowIndex].Cells["PurchasingPrice"].Value.ToString().Split(' ')[0];

            //    FormPurchase formPurchase = new FormPurchase(pCode, pName, pPrice, pStock, this, this.AdminHomeRef);
            //    formPurchase.ShowDialog();
            //}
        }

        

        private void dgvSalesDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    DataGridViewRow selectedRow = dgvSalesDetail.Rows[e.RowIndex];

                    string invoice = selectedRow.Cells["InvoiceNo"].Value.ToString();
                    string issueDate = selectedRow.Cells["IssueDate"].Value.ToString();
                    string totalDiscount = selectedRow.Cells["TotalDiscount"].Value.ToString();
                    string recievedAmount = selectedRow.Cells["ReceivedAmount"].Value.ToString();
                    string returnedAmount = selectedRow.Cells["ReturnedAmount"].Value.ToString();

                    FormSaleDetails formSaleDetails = new FormSaleDetails(invoice, issueDate, totalDiscount, recievedAmount, returnedAmount);
                    formSaleDetails.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
            
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            string sql = @"
                            SELECT 
                                CONCAT(N'৳ ', FORMAT(SUM(Purchase_totalprice), 'N2')) AS TotalPurchase,
                                DATEADD(DAY, -DATEPART(WEEKDAY, Purchase_Date) + 2, CAST(Purchase_Date AS DATE)) AS WeekStart
                            FROM purchase
                            WHERE Purchase_Date >= DATEADD(DAY, -28, GETDATE())
                            GROUP BY DATEADD(DAY, -DATEPART(WEEKDAY, Purchase_Date) + 2, CAST(Purchase_Date AS DATE))
                            ORDER BY WeekStart;";

            this.TotalSale(sql);
            this.TotalPurchase(sql);
            var status = "Total Profits of " + this.DayBetween + " days";
            this.TotalProfit(status);
        }
    }
}
