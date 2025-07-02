using InventoryManagement.App;
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

namespace InventoryManagement.Salesman.Activity
{
    public partial class FormSalesmanHome : Form
    {
        private FormLogin FL { get; set; } // Reference to FormLogin
        internal string LoggedInSalesmanId { get; set; }
        private Database.DataAccess Da { get; set; }
        public FormSalesmanHome(FormLogin fl, string  salesmanId = "SLM-001")
        {
            InitializeComponent();
            this.FL = fl; 
            this.LoggedInSalesmanId = salesmanId; 
            this.Da = new Database.DataAccess();
            this.LoadUserData();
        }
        public FormSalesmanHome()
        {
            InitializeComponent();
        }

        private void FormSalesmanHome_Load(object sender, EventArgs e)
        {
            SaleHistoryControl saleHistoryControl = new SaleHistoryControl(this, this.LoggedInSalesmanId);
            addUserControl(saleHistoryControl);
            
        }
        
        // user data
        internal void LoadUserData()
        {
            try
            {
                var sql = @"Select * from Users where U_ID = @salesmanId;";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@salesmanId", this.LoggedInSalesmanId) };
                var ds = this.Da.ExecuteQuery(sql, parameters);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        var row = ds.Tables[0].Rows[0];
                        this.lblUserName.Text = row["U_Name"].ToString();
                        string imagePath = row["U_Photo"].ToString();
                        if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                        {
                            this.pcbProfile.Image = Image.FromFile(imagePath);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("User Info Can't fetch");
            }
            
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlField.Controls.Clear();
            pnlField.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleControl saleControl = new SaleControl(this, this.LoggedInSalesmanId);
            addUserControl(saleControl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaxRestore.Image = Properties.Resources.Restore;
                this.metroToolTip.SetToolTip(this.btnMaxRestore, "Restore");
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaxRestore.Image = Properties.Resources.Maximize;
                this.metroToolTip.SetToolTip(this.btnMaxRestore, "Maximize");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SaleHistoryControl saleHistoryControl = new SaleHistoryControl(this, this.LoggedInSalesmanId);
            addUserControl(saleHistoryControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.FL.Show();
            this.Hide();
        }
    }
}
