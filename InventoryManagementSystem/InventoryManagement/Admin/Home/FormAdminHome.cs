using InventoryManagement.Admin.Activity.Dashboard;
using InventoryManagement.Admin.Activity.ManageUser;
using InventoryManagement.Admin.Activity.Product;
using InventoryManagement.Admin.Registration;
using InventoryManagement.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity
{
    public partial class FormAdminHome : Form
    {
        private Guna.UI2.WinForms.Guna2Button currentBtn;

        private FormLogin FormLoginRef { get; set; }
        internal string AdminId { get; set; } 
        private Database.DataAccess Da { get; set; } 
        public FormAdminHome()
        {
            InitializeComponent();
        }
        public FormAdminHome(FormLogin form, string adminId = "ADM-001")
        {
            InitializeComponent();
            this.FormLoginRef = form;
            this.AdminId = adminId;
            this.Da = new Database.DataAccess();
            this.LoadUserData();
        }

        internal void LoadUserData()
        {
            var sql = @"Select * from Users where U_ID = @adminId;";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@adminId", this.AdminId) };
            var ds = this.Da.ExecuteQuery(sql, parameters);
            if (ds != null)
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    var row = ds.Tables[0].Rows[0];
                    this.lblAdminName.Text = row["U_Name"].ToString();
                    string imagePath = row["U_Photo"].ToString();
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        this.pcbProfile.Image = Image.FromFile(imagePath);
                    }
                }
            }
        }
        private void FormAdminHome_Load(object sender, EventArgs e)
        {
            UserControlAdminDashboard dashboard = new UserControlAdminDashboard();
            addUserControl(dashboard);
        }

        //...... button Color methods
        private void ActivateButton(object senderBtn)
        {
            if(senderBtn != null)
            { 
                currentBtn = (Guna.UI2.WinForms.Guna2Button)senderBtn;
                currentBtn.FillColor = Color.FromArgb(255, 187, 8);
                currentBtn.BackColor = Color.FromArgb(255, 187, 8);//
            }
        }
        
       


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            productTransition.Start();
            productTransition.Interval = 5;

        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            ListProductControl list= new ListProductControl(this);
            addUserControl(list);
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProductControl addProduct = new AddProductControl(this);
            addUserControl(addProduct);
        }
        private void btnManageUser_Click(object sender, EventArgs e)
        {
            manageTransition.Start();
            manageTransition.Interval = 5;
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            ViewUserControl viewUser = new ViewUserControl(this);
            addUserControl(viewUser);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserControl addUser = new AddNewUserControl(this);
            addUserControl(addUser);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

        }


        bool productExpand = false;
        private void productTransition_Tick(object sender, EventArgs e)
        {
            if(productExpand == false)
            {
                pnlProductContainer.Height += 10;
                if (pnlProductContainer.Height >= 138)
                {
                    productExpand = true;
                    productTransition.Stop();
                }
            }
            else
            {
                pnlProductContainer.Height -= 10;
                if (pnlProductContainer.Height <= 40)
                {
                    productExpand = false;
                    productTransition.Stop();
                }
            }
        }

        bool manageExpaned = false;
        private void manageTransition_Tick(object sender, EventArgs e)
        {
            if (manageExpaned == false)
            {
                pnlManageContainer.Height += 10;
                if (pnlManageContainer.Height >= 103)
                {
                    manageExpaned = true;
                    manageTransition.Stop();
                }
            }
            else
            {
                pnlManageContainer.Height -= 10;
                if (pnlManageContainer.Height <= 40)
                {
                    manageExpaned = false;
                    manageTransition.Stop();
                }
            }
        }


        //add user control
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UserControlAdminDashboard dashboard = new UserControlAdminDashboard();
            addUserControl(dashboard);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.FormLoginRef.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsControl settings = new SettingsControl();
            addUserControl(settings);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_MouseDown(object sender, MouseEventArgs e)
        {
            btnProduct.Checked = true;
        }

        private void btnProduct_MouseMove(object sender, MouseEventArgs e)
        {
            btnProduct.Checked = false;
        }

      

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryControl categoryControl = new CategoryControl();
            addUserControl(categoryControl);
        }

        private void btnMaxRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaxRestore.Image = Properties.Resources.Restore; 
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaxRestore.Image = Properties.Resources.Maximize;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ListProductControl lpc = new ListProductControl(this);
            addUserControl(lpc);
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pnlTopBar_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaxRestore.Image = Properties.Resources.Restore;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaxRestore.Image = Properties.Resources.Maximize;
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
           
        }
    }
}
