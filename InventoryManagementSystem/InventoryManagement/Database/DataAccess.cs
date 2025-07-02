using System;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace InventoryManagement.Database
{
    public class DataAccess
    {
        public SqlConnection SqlConn { get; set; } // Contain the Connection String and Connection Object
        public SqlCommand SqlCmd { get; set; } //Contain the Command object and Command Text
        public SqlDataAdapter Sda { get; set; }  // Contain the Data Adapter Object
        public DataSet Ds { get; set; } // Contain the DataSet Object
        public DataTable Dt { get; set; } // Contain the DataTable Object

        public DataAccess()
        {
            this.SqlConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SuperShopDB;Persist Security Info=True;User ID=sa;Password=C#.AIUB.2025;");
            this.SqlConn.Open(); // Open the connection to the database
        }

        private SqlCommand QueryText(string query)
        {
            return this.SqlCmd = new SqlCommand(query, this.SqlConn); // Set the command text and connection
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.Sda = new SqlDataAdapter(this.QueryText(sql));
                this.Ds = new DataSet(); // Create a new DataSet to hold the results
                this.Sda.Fill(Ds);
                return Ds; // Return the filled DataSet
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataSet ExecuteQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                this.QueryText(sql);
                
                if (parameters != null)
                {
                    this.SqlCmd.Parameters.AddRange(parameters);
                }
                this.Sda = new SqlDataAdapter(this.SqlCmd);
                this.Ds = new DataSet(); 
                this.Sda.Fill(this.Ds);
                return Ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error executing DML query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                this.SqlCmd = new SqlCommand(sql, this.SqlConn);
                this.Sda = new SqlDataAdapter(this.SqlCmd); // Initialize the SqlDataAdapter with the command
                this.Ds = new DataSet(); // Create a new DataSet to hold the results
                this.Sda.Fill(this.Ds); // Fill the DataSet with the results of the query
                return Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Return null if there is an error
            }
        }
        public DataTable ExecuteQueryTable(string sql, SqlParameter[] parameters)
        {
            try
            {
                this.QueryText(sql);

                if (parameters != null)
                {
                    this.SqlCmd.Parameters.AddRange(parameters);
                }
                this.Sda = new SqlDataAdapter(this.SqlCmd);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing DML query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int ExecuteDMLQuery(string sql)
        {
            try
            {
                this.SqlCmd = new SqlCommand(sql, this.SqlConn);
                return this.SqlCmd.ExecuteNonQuery(); // Execute the command

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing DML query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 if there is an error
            }
        }


        public int ExecuteDMLQuery(string sql, SqlParameter[] parameters, SqlTransaction transaction)
        {
            try
            {
                this.SqlCmd = new SqlCommand(sql, this.SqlConn, transaction);
                if (parameters != null)
                {
                    this.SqlCmd.Parameters.AddRange(parameters);
                }
                return this.SqlCmd.ExecuteNonQuery(); // Execute the command
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing DML query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public int ExecuteDMLQuery(string sql, SqlParameter[] parameters)
        {
            int rowsAffected = -1;
            SqlTransaction transaction = this.SqlConn.BeginTransaction();
            try
            {
                using (this.SqlCmd = new SqlCommand(sql, this.SqlConn, transaction))
                {
                    if (parameters != null)
                    {
                        this.SqlCmd.Parameters.AddRange(parameters);
                    }

                    rowsAffected = this.SqlCmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            return rowsAffected; 
        }

        public void DataAccessDispose()
        {
            if (this.SqlConn != null && this.SqlConn.State == ConnectionState.Open)
            {
                this.SqlConn.Close();
            }
            if (this.SqlConn != null)
            {
                this.SqlConn.Dispose();
                this.SqlConn = null;
            }
        }

    }
}
