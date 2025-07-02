using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace InventoryManagement.App
{
    public partial class FormLogin : Form
    {
        //private string Role { get; set; } = "Admin"; 

        Database.DataAccess Da { get; set; } 
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new Database.DataAccess(); 
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
       
        private void chkPasswordVisiblity_CheckedChanged(object sender, EventArgs e)
        {
              txtUserPassword.UseSystemPasswordChar = !chkPasswordVisiblity.Checked;
        }


        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            new Admin.FormAdminRegistration(this).Show();
            this.Hide();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string sql = @"select * from Users;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            bool isValidUser = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txtUserID.Text == dt.Rows[i]["U_ID"].ToString() && txtUserPassword.Text == dt.Rows[i]["U_Password"].ToString())
                {
                    isValidUser = true;
                    string role = dt.Rows[i]["U_Role"].ToString();

                    //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (role == "Admin")
                    {
                        new Admin.Activity.FormAdminHome(this, this.txtUserID.Text).Show();
                        this.txtUserID.Clear();
                        this.txtUserPassword.Clear();
                    }
                    else if (role == "Salesman")
                    {
                        new Salesman.Activity.FormSalesmanHome(this, this.txtUserID.Text).Show(); // Example
                        this.txtUserID.Clear();
                        this.txtUserPassword.Clear();
                    }

                    this.Hide();
                    return;
                }
            }

            if (!isValidUser)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnSMTP_Click(object sender, EventArgs e)
        {
            new App.FormSMTP(this).ShowDialog();
        }

        private void btnForgotPasword_Click(object sender, EventArgs e)
        {
            new App.FormResetPassword(this).ShowDialog();
        }
    }
}
