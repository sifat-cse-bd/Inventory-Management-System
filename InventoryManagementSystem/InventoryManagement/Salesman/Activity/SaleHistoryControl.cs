using InventoryManagement.Admin.Activity.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Salesman.Activity
{
    public partial class SaleHistoryControl : UserControl
    {
        Database.DataAccess Da { get; set; }
        private string FromDate { get; set; }
        private string ToDate { get; set; }
        private string DayBetween { get; set; }
        internal string LoggedInSalesmanId { get; set; }
        private FormSalesmanHome SalesmanHomeRef { get; set; }
        public SaleHistoryControl(FormSalesmanHome form, string userId)
        {
            InitializeComponent();
            this.SalesmanHomeRef = form;
            this.Da = new Database.DataAccess();
            this.LoggedInSalesmanId = userId;
            this.TotalSale();
            this.PopulateSaleGridView();
            this.LoadingUserInfo();
        }

        private void LoadingUserInfo()
        {
            try
            {
                var sql = @"SELECT * FROM users
                            JOIN Salesman ON users.U_ID = Salesman.S_ID
                            WHERE users.U_ID = @userID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                     new SqlParameter("@userID", LoggedInSalesmanId)
                };

                var dt = Da.ExecuteQueryTable(sql, parameters);
                if(dt != null)
                {
                    this.lblID.Text += dt.Rows[0]["U_ID"].ToString();
                    this.lblProfileName.Text = dt.Rows[0]["U_Name"].ToString();
                    this.lblEmail.Text = dt.Rows[0]["U_Email"].ToString();
                    this.lblRole.Text = dt.Rows[0]["U_Role"].ToString();
                    this.lblGender.Text += dt.Rows[0]["Gender"].ToString();
                    this.lblNID.Text += dt.Rows[0]["S_NID"].ToString();
                    var city = dt.Rows[0]["S_City"].ToString();
                    var upazilla = dt.Rows[0]["S_Upazilla"].ToString();
                    var area = dt.Rows[0]["S_Area"].ToString();

                    this.lblAddress.Text += $"{area}, {upazilla}, {city}";

                    this.lblJoiningDate.Text += Convert.ToDateTime(dt.Rows[0]["U_Joining_Date"]).ToString("dd/MMM/yyyy");
                    string imagePath = dt.Rows[0]["U_Photo"].ToString();
                    
                    if (File.Exists(imagePath))
                    {

                        pcbProfile.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Image not found!");
                        pcbProfile.Image = null;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error to load user about");
            }
        }
        private void PopulateSaleGridView(string sql = null)
        {
            try
            {
                if (sql == null)
                {
                    sql = @"SELECT 
                                    b.IssueDate, 
                                    b.ReceivedAmount, 
                                    b.ReturnedAmount,
                                    b.TotalDiscount,
                                    bs.InvoiceNO, 
                                    N'৳' + FORMAT(SUM(bs.Sale_SubTotal), 'N2') AS Total, 
                                    sb.S_ID, 
                                    u.U_Name 
                                FROM BillSale bs
                                JOIN Bill b ON b.InvoiceNo = bs.InvoiceNo
                                JOIN SalesmanBill sb ON sb.InvoiceNo = b.InvoiceNo
                                LEFT JOIN Users u ON u.U_ID = sb.S_ID
                                WHERE sb.S_ID = @salesmanId
                                GROUP BY 
                                    bs.InvoiceNO, 
                                    b.IssueDate,
                                    b.TotalDiscount,
                                    b.ReceivedAmount, 
                                    b.ReturnedAmount,
                                    sb.S_ID, 
                                    u.U_Name;";

                }

                SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@salesmanId", this.LoggedInSalesmanId) };

                var dt = Da.ExecuteQueryTable(sql, parameter);
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.dgvSalesDetail.AutoGenerateColumns = false;
                    this.dgvSalesDetail.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Selling Data Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TotalSale(string sql = null, SqlParameter[] parameter = null)
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    this.lblSalesStatus.Text = "Sales of last 28 days";
                    sql = @"SELECT CONCAT(N'৳ ', FORMAT(SUM(bs.Sale_SubTotal), 'N2')) AS TotalSale
                            FROM BillSale bs
                            INNER JOIN Bill b ON b.InvoiceNo = bs.InvoiceNo
                            INNER JOIN SalesmanBill sb ON sb.InvoiceNo = b.InvoiceNo
                            WHERE b.IssueDate >= DATEADD(DAY, -28, GETDATE())
                              AND sb.S_ID = @salesmanId";

                    // Default parameter only when not provided
                    parameter = new SqlParameter[]
                    {
                        new SqlParameter("@salesmanId", this.LoggedInSalesmanId)
                    };
                }

                var dt = Da.ExecuteQueryTable(sql, parameter);
                lblTotalSale.Text = (dt != null && dt.Rows.Count > 0) ? dt.Rows[0][0].ToString() : "৳ 0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total sale: " + ex.Message);
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

            string sql = @"SELECT CONCAT(N'৳ ', FORMAT(SUM(bs.Sale_SubTotal), 'N2')) AS Total
                            FROM BillSale bs
                            INNER JOIN Bill b ON b.InvoiceNo = bs.InvoiceNo
                            INNER JOIN SalesmanBill sb ON sb.InvoiceNo = b.InvoiceNo
                            WHERE CAST(b.IssueDate AS DATE) BETWEEN @fromDate AND @toDate
                            AND sb.S_ID = @salesmanId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@fromDate", this.FromDate),
                new SqlParameter("@toDate", this.ToDate),
                new SqlParameter("@salesmanId", this.LoggedInSalesmanId)
            };


            this.TotalSale(sql, parameters);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!IsValidDateDuration()) return;

            this.CustomDurationTotalSale();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            this.TotalSale();
        }

        private void dgvSalesDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
