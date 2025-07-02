using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace InventoryManagement.Database
{
    internal class SalesmanData : User
    {
        internal SalesmanData(string role, string id, string name, string email, string phone, string userName, string password, string sourceImagePath)
            : base(role, id, name, email, phone, userName, password, sourceImagePath)
        { }

    }

}
