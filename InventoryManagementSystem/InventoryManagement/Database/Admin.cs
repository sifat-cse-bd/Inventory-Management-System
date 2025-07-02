using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagement.Database
{
    internal class AdminData : User
    {
        internal AdminData()
        { }
        internal AdminData(string role, string id, string name, string email, string phone, string userName, string password, string sourceImagePath) : base(role, id, name, email, phone, userName, password, sourceImagePath)
        { }

        // Admin Sign In validation

        

    }
}
