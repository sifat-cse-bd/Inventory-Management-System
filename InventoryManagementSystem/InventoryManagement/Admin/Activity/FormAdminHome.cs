using InventoryManagement.Admin.Registration;
using InventoryManagement.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity
{
    public partial class FormAdminHome : Form
    {
        private FormLogin Home{get; set; }
        public FormAdminHome()
        {
            InitializeComponent();
        }
        public FormAdminHome(FormLogin home)
        {
            InitializeComponent();
            this.Home = home;
        }
        private void FormAdminHome_Load(object sender, EventArgs e)
        {
            UserControlAdminDashboard dashboard = new UserControlAdminDashboard();
            addUserControl(dashboard);
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
            UserControlListProduct list= new UserControlListProduct();
            addUserControl(list);
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            UserControlAddProduct addProduct = new UserControlAddProduct();
            addUserControl(addProduct);
        }
        private void btnManageUser_Click(object sender, EventArgs e)
        {
            manageTransition.Start();
            manageTransition.Interval = 5;
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            UCFormViewUser viewUser = new UCFormViewUser();
            addUserControl(viewUser);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            UserControlAddNewUser addUser = new UserControlAddNewUser();
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
                if (pnlManageContainer.Height >= 138)
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
            Home.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UserControlSettings settings = new UserControlSettings();
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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        
    }
}
