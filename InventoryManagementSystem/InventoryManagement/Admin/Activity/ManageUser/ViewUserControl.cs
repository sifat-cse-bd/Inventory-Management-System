using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity.ManageUser
{
    public partial class ViewUserControl : UserControl
    {
        private FormAdminHome AdminHomeRef { get; set; }
        private Database.DataAccess Da {  get; set; }
        private string SelectedUserId { get; set; } // user id
        private string SelectedImagePath { get; set; } // user image path
        private string SelectedRole { get; set; }

        public ViewUserControl(FormAdminHome form)
        {
            InitializeComponent();
            this.AdminHomeRef = form;
            this.Da = new Database.DataAccess();
            this.PopulateGridView();
        }

        private void ViewUserControl_Load(object sender, EventArgs e)
        {
            
            this.pnlModify.Visible = false;
        }

        private void PopulateGridView(string sql = "SELECT * FROM Users", SqlParameter[] parameters = null )
        {
            try
            {
                DataSet ds;
                if(parameters == null)
                {
                    ds = Da.ExecuteQuery(sql);
                }
                else
                {
                    ds = Da.ExecuteQuery(sql, parameters);
                }


                if (ds.Tables.Count > 0)
                {
                    this.dgvUser.AutoGenerateColumns = false;
                    this.lblUserFoundStatus.Visible = false;
                    this.dgvUser.DataSource = ds.Tables[0];
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        this.lblUserFoundStatus.Visible = true;
                        //MessageBox.Show("No users found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data returned from the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.pnlUserInfoContainer.Controls.Clear();
            this.pnlUserInfoContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

       
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
           // pnlModify.Visible = true ;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                pnlModify.Visible = true;

                try
                {
                    DataGridViewRow row = dgvUser.Rows[e.RowIndex];

                    
                    this.SelectedUserId = row.Cells["UserID"]?.Value?.ToString();
                    this.SelectedImagePath = row.Cells["UserPhoto"]?.Value?.ToString();
                    this.SelectedRole = row.Cells["UserRole"].Value?.ToString();
                    
                    if (this.SelectedUserId == null)
                    {
                        return;
                    }
                    UserInfoControl userInfoControl = new UserInfoControl(this, this.SelectedUserId, SelectedImagePath);
                    AddUserControl(userInfoControl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error reading selected row:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowUserInfoPanel()
        {
            this.AddUserControl(new UserInfoControl(this, this.SelectedUserId, SelectedImagePath));
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var sql = $"SELECT * FROM Users WHERE U_Role = 'Admin'";
            this.PopulateGridView(sql);
            this.pnlModify.Visible = false;
        }

        private void btnSalesman_Click(object sender, EventArgs e)
        {
            var sql = $"SELECT * FROM Users WHERE U_Role = 'Salesman'";
            this.PopulateGridView(sql);
            this.pnlModify.Visible = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.pnlModify.Visible = false;
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "UserPhoto")
            {
                 if (e.Value is string imagePath)
                {
                    string fullPath = Path.Combine(Application.StartupPath, "Images", imagePath);

                    if (File.Exists(fullPath))
                    {
                        e.Value = Image.FromFile(fullPath);
                    }
                }
            }
        }


        private SqlTransaction BeginTransaction()
        {
            if (Da.SqlConn.State != ConnectionState.Open)
                Da.SqlConn.Open();
            return Da.SqlConn.BeginTransaction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.SelectedUserId)) // safety check
            {
                MessageBox.Show("Please select a user first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete\nUser: {this.Name}?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (confirmResult == DialogResult.No)
                return;

            var transaction = BeginTransaction();

            try
            {
                if (this.SelectedRole == "Admin")
                {
                    var sqlAdmin = "DELETE FROM Admin WHERE A_ID = @userId;";
                    SqlParameter[] adminParam = new SqlParameter[]
                    {
                new SqlParameter("@userId", this.SelectedUserId)
                    };
                    this.Da.ExecuteDMLQuery(sqlAdmin, adminParam, transaction);
                }
                else
                {
                    var sqlSalesman = "DELETE FROM Salesman WHERE S_ID = @userId;";
                    SqlParameter[] salesParam = new SqlParameter[]
                    {
                    new SqlParameter("@userId", this.SelectedUserId)
                    };
                    this.Da.ExecuteDMLQuery(sqlSalesman, salesParam, transaction);

                    var sqlAdminSalesman = "DELETE FROM adminsalesman WHERE S_ID = @userId;";
                    SqlParameter[] adminSalesParam = new SqlParameter[]
                    {
                    new SqlParameter("@userId", this.SelectedUserId)
                    };
                    this.Da.ExecuteDMLQuery(sqlAdminSalesman, adminSalesParam, transaction);
                }

                var sqlUser = "DELETE FROM Users WHERE U_ID = @userId;";
                SqlParameter[] userParam = new SqlParameter[]
                {
                    new SqlParameter("@userId", this.SelectedUserId)
                };
                this.Da.ExecuteDMLQuery(sqlUser, userParam, transaction);

                transaction.Commit();

                // Delete image after transaction
                if (dgvUser.SelectedRows.Count > 0)
                {
                    var row = dgvUser.SelectedRows[0];
                    var img = row.Cells["UserPhoto"].Value as Image;

                    if (img != null)
                    {
                        img.Dispose();                     // Unlock the file
                        row.Cells["UserPhoto"].Value = null;   // Clear reference
                    }
                }


                //  Now delete image safely
                Database.ImageManager im = new Database.ImageManager();
                im.DeleteImage(this.SelectedImagePath);


                this.PopulateGridView();
                pnlUserInfoContainer.Controls.Clear();

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error while deleting user:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object LoadImageWithoutLock(object imagePath)
        {
            throw new NotImplementedException();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = " SELECT * FROM Users WHERE U_Name LIKE @searchText OR U_Email LIKE @searchText OR U_ID LIKE @searchText";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter( "@searchText", "%" + this.txtSearch.Text.Trim() + "%")
            };
            
            this.PopulateGridView(sql, parameters);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           this.txtSearch.Clear();
        }
    }
}
