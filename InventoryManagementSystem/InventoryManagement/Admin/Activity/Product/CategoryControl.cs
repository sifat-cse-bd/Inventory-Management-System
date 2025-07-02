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

namespace InventoryManagement.Admin.Activity.Product
{
    public partial class CategoryControl : UserControl
    {
        Database.DataAccess Da {  get; set; }   
        public CategoryControl()
        {
            InitializeComponent();
            this.Da = new Database.DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select *  from category;")
        {
            this.lblCatFoundStatus.Visible = false;
            var ds = Da.ExecuteQuery(sql);
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count == 0)
            this.lblCatFoundStatus.Visible = true;
            this.FlowID();
        }
        private void PopulateGridView(SqlParameter[] parameters, string sql = "select *  from category;")
        {
            this.lblCatFoundStatus.Visible = false;
            var ds = Da.ExecuteQuery(sql, parameters);
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count == 0)
            this.lblCatFoundStatus.Visible = true;
            this.FlowID();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValid())
                {
                    return;
                }

                var sql = "select * from Category where Cat_ID = @catID";
                SqlParameter[] parameters = new SqlParameter[]{ new SqlParameter("@catID", this.txtCatID.Text)};
                var ds = Da.ExecuteQuery(sql, parameters);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var query = @"UPDATE CATEGORY 
                                SET Cat_Name = @catName, 
                                CAT_DESCRIPTION = @catDescription
                                WHERE CAT_ID = @catID";

                    SqlParameter[] updateParameters = new SqlParameter[]
                    {
                        new SqlParameter("@catName", this.txtCategoryName.Text),
                        new SqlParameter("@catDescription", this.txtDescription.Text),
                        new SqlParameter("@catID", this.txtCatID.Text)
                    };

                    var count = Da.ExecuteDMLQuery(query, updateParameters);

                    if (count == 1) 
                    { 
                        MessageBox.Show("Data has been updated.");
                    }
                    else
                    {
                        MessageBox.Show("Data hasn't been updated.");
                    }
                }
                else
                {
                    // Insert Fresh Data
                    var query = @"INSERT INTO CATEGORY VALUES (@catID, @catName, @catDescription);";
                    SqlParameter[] insertParameters = new SqlParameter[]
                    {
                        new SqlParameter("@catID", this.txtCatID.Text),
                        new SqlParameter("@catName", this.txtCategoryName.Text),
                        new SqlParameter("@catDescription", this.txtDescription.Text)
                    };
                    int count = Da.ExecuteDMLQuery(query, insertParameters);
                    if (count == 1)
                    {
                        MessageBox.Show("Category has been Added to the list");
                        this.ClearAll();
                        this.FlowID();
                    }
                    else
                    {
                        MessageBox.Show("Category hasn't been  Added to the list");
                    }
                }
                
                this.PopulateGridView();
                this.ClearAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtCatID.Text))
            {
                MessageBox.Show("Id Can't be null.");
                return false;
            }

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please Enter a Category Name");
                return false;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                var result = MessageBox.Show("Are you sure you want to keep the description empty?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Category WHERE Cat_Name LIKE @catName + '%'";
            SqlParameter[] parameters = { new SqlParameter("@catName", this.txtSearchBox.Text) };
            this.PopulateGridView(parameters, sql);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Category WHERE Cat_Name LIKE @catName + '%'";
            SqlParameter[] parameters = { new SqlParameter("@catName", this.txtSearchBox.Text)};
            this.PopulateGridView(parameters, sql);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtCategoryName.Clear();
            this.txtDescription.Clear();
            this.txtSearchBox.Clear();
            this.dgvCategory.ClearSelection();
            this.btnAdd.Text = "Add";
        }

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            this.btnAdd.Text = "Update";
            this.txtCatID.Text = this.dgvCategory.CurrentRow.Cells[0].Value.ToString();
            this.txtCategoryName.Text = this.dgvCategory.CurrentRow.Cells[1].Value.ToString();
            this.txtDescription.Text = this.dgvCategory.CurrentRow.Cells[2].Value.ToString();
        }

        private void FlowID()
        {
            Generator.IdGenerator gi = new Generator.IdGenerator();
            this.txtCatID.Text = gi.GenerateCategoryId();
        }

        private void txtCategroyName_Leave(object sender, EventArgs e)
        {
            var sql = "select Cat_Name from Category where Cat_Name = '" + this.txtCategoryName.Text + "';";
            var ds = Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Category Name already exists. Please choose a different name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCategoryName.Clear();
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                if (!this.IsValidToDelete())
                    return;

                string id = dgvCategory.CurrentRow.Cells["CatID"].Value.ToString();
                string name = dgvCategory.CurrentRow.Cells["categoryName"].Value.ToString();

                string sql = @"
                                DELETE FROM Category WHERE Cat_ID = @catID;
                                UPDATE ProductCategory SET Cat_ID = NULL WHERE Cat_ID = @catID;";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@catID", id)
                };

                int count = Da.ExecuteDMLQuery(sql, parameters);

                if (count >= 1)
                {
                    MessageBox.Show($"Category '{name.ToUpper()}' deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category was not deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred!\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsValidToDelete()
        {
            if (dgvCategory.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a category to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            string catId = dgvCategory.CurrentRow.Cells["CatID"].Value.ToString();

            string sql = "SELECT Cat_ID FROM ProductCategory WHERE Cat_ID = @catID;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@catID", catId)
            };

            var ds = Da.ExecuteQuery(sql, parameters);

            string message = ds.Tables[0].Rows.Count > 0
                ? "This category is associated with some products.\nDo you still want to delete it?"
                : "Are you sure you want to delete this category?";

            DialogResult result = MessageBox.Show(
                message,
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            return result == DialogResult.Yes;
        }


    }
}
