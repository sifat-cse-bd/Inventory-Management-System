using System;
using System.Data.SqlClient;    
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using InventoryManagement.Database;


namespace InventoryManagement.Generator
{
    internal class IdGenerator
    {
        private string Role { get; set; } // Role of the user or entity for which ID is being generated
        private DataAccess Da { get; set; }
        internal IdGenerator()
        {
             this.Da = new Database.DataAccess();
        }

        internal string GenerateAdminId()
        {
            try
            {
                string query = @"select Max(U_ID) from Users WHERE U_Role = 'Admin'";
                
                DataSet ds = this.Da.ExecuteQuery(query);
                string lastId = ds.Tables[0].Rows[0][0].ToString();

                if(string.IsNullOrWhiteSpace(lastId))
                {
                    return "ADM-001";
                }

                string[] temp = lastId.Split('-');
                int id = Convert.ToInt32(temp[1]);
                string newID = "ADM-" + (++id).ToString("D3");

                return newID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Admin ID: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Salesman Id Generation
        internal string GenerateSalesmanId()
        {
            try
            {
                string query = @"select Max(U_ID) from Users WHERE U_Role = 'Salesman'";

                DataSet ds = this.Da.ExecuteQuery(query);
                string lastId = ds.Tables[0].Rows[0][0].ToString();

                if (string.IsNullOrWhiteSpace(lastId))
                {
                    return "SLM-001";
                }

                string[] temp = lastId.Split('-');
                int id = Convert.ToInt32(temp[1]);
                string newID = "SLM-" + (++id).ToString("D3");

                return newID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Salesman ID: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal string GenerateProductCode()
        {
            try
            {
                string query = @"select Max(P_ID) from Product;";
                DataSet ds = this.Da.ExecuteQuery(query);

                string lastId = ds.Tables[0].Rows[0][0].ToString();
                if (string.IsNullOrWhiteSpace(lastId))
                {
                    return "PRD00001";
                }
                string numberPart = lastId.Substring(3);
                int.TryParse(numberPart, out int p);
                p++;
                string newID = "PRD" + p.ToString("D5");
                return newID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Product ID: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal string GenerateCategoryId()
        {   
            try
            {
                string query = @"select Max(Cat_ID) from Category;";
                DataSet ds = this.Da.ExecuteQuery(query);

                string lastId = ds.Tables[0].Rows[0][0].ToString();
                if (string.IsNullOrWhiteSpace(lastId))
                {
                    return "CAT00001"; // 8 Length
                }
                string numberPart = lastId.Substring(3);
                int.TryParse(numberPart, out int c);
                c++;
                string newID = "CAT" + c.ToString("D5");
                return newID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Category ID: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal string GenerateDiscountId()
        {
            try
            {
                string query = "select Max(Discount_ID) from Discount;";
                DataSet ds = this.Da.ExecuteQuery(query);

                string lastId = ds.Tables[0].Rows[0][0].ToString();
                if (string.IsNullOrWhiteSpace(lastId))
                {
                    return "DIS00001"; // 8 Length
                }
                string numberPart = lastId.Substring(3);
                int.TryParse(numberPart, out int c);
                c++;
                string newID = "DIS" + c.ToString("D5");
                return newID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Discount ID: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static string _lastGeneratedId = "";
        private static readonly object _lock = new object();

        internal string GenerateSaleId()
        {
            lock (_lock)
            {
                string id;
                do
                {
                    id = DateTime.Now.ToString("yyMMddHHmmssfff");

                    if (id == _lastGeneratedId)
                        System.Threading.Thread.Sleep(1);
                } while (id == _lastGeneratedId);

                _lastGeneratedId = id;
                return id;
            }
        }




        internal string GenerateInvoiceNo()
        {
            try
            {
                string today = DateTime.Now.ToString("dMyyyy-HHmmss");
                var id = "INV-" + today;
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating  InvoiceNo: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal string GeneratePurchaseID()
        {
            try
            {
                string today = DateTime.Now.ToString("dMyyyy-HHmmss");
                var id = "C-" + today;
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating  InvoiceNo: " + ex.Message, "ID Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
