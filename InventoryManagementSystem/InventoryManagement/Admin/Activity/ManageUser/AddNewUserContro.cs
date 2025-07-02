using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Admin.Activity
{
    public partial class AddNewUserControl : UserControl
    {
        private FormAdminHome FormAdminHomeRef { get; set; }
        private string AdminID { get; set; }
        public AddNewUserControl(FormAdminHome form)
        {
            InitializeComponent();
            this.FormAdminHomeRef = form;
        }

        

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAdmin.Checked)
            {
                pnlContainer.Controls.Clear();
                AddAdminControl admin = new AddAdminControl(this.FormAdminHomeRef);
                admin.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(admin);
            }
        }

        private void rdSalesman_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSalesman.Checked)
            {
                pnlContainer.Controls.Clear();
                AddSalesmanControl salesman = new AddSalesmanControl(this.FormAdminHomeRef);
                salesman.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(salesman);
            }
        }

        private void createNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            AddAdminControl admin = new AddAdminControl(this.FormAdminHomeRef);
            admin.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(admin);
        }

        private void createNewSalesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            AddSalesmanControl salesman = new AddSalesmanControl(this.FormAdminHomeRef);
            salesman.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(salesman);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();        // Remove all existing controls
            pnlContainer.Controls.Add(panel1);    // Add panel1 to the container
            panel1.Visible = true;
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();        // Remove all existing controls
            pnlContainer.Controls.Add(panel1);    // Add panel1 to the container
            panel1.Visible = true;                // Make sure it's visible

        }
    }
}
