using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Database
{
    internal class Data
    {
        internal string Role { get; set; } // Added Role property to store user role
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Phone { get; set; }
        internal string Email { get; set; }
        internal string UserName { get; set; }
        internal string Password { get; set; }
        internal string PhotoPath { get; set; }
        
        internal Data() { } // Default constructor
        internal Data(string role, string id, string name, string email, string phone, string userName, string password, string sourceImagePath)
        {
            this.Role = role; // Initialize the Role property
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
            this.PhotoPath = sourceImagePath; // Store the image file path

        }

        // Data Insertion Method Named Push
        internal virtual bool Push(string query)
        {
            string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SuperShopDB;Persist Security Info=True;User ID=sa;Password=C#.AIUB.2025";
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.Parameters.AddWithValue("@NAME", Name);
                    cmd.Parameters.AddWithValue("@EMAIL", Email);
                    cmd.Parameters.AddWithValue("@PHONE", Phone);
                    cmd.Parameters.AddWithValue("@USERNAME", UserName);
                    cmd.Parameters.AddWithValue("@PASSWORD", Password);

                    ImageManager imgManager = new ImageManager();
                    string savedImagePath = imgManager.SaveImageToUserFolder(this.PhotoPath); // Save the image to the user's folder
                    cmd.Parameters.AddWithValue("@PHOTO", savedImagePath);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error inserting data: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return rowsAffected > 0;
        }


        //
        internal bool SignInValidation(string id, string password)
        {
            string role = null;
            if (id.Substring(0,3) == "ADM")
            {
                role = "ADMIN";
            }
            else if (id.Substring(0,3) == "SLM")
            {
                role = "SALESMAN";
            }

            string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SuperShopDB;Persist Security Info=True;User ID=sa;Password=C#.AIUB.2025";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT ID, PASSWORD FROM {role} WHERE {role}_ID = @ID AND {role}_PASSWORD = @PASSWORD";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Always add both parameters
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during sign-in validation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

    }
}
