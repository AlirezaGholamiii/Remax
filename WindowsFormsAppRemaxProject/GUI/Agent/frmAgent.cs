using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppRemaxProject
{
    public partial class frmAgent : Form
    {
        DataTable tabEmployee;

        public frmAgent()
        {
            InitializeComponent();
            pnlDesktop.Controls.Clear();
            frmHome f = new frmHome();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();

            tabEmployee = clsGlobal.mySet.Tables["Employees"];

            foreach(DataRow Employee in tabEmployee.Rows)
            {
                if(Employee["EmployeeID"].ToString() == LoginPage.currentAgent)
                {
                    lblUserName.Text = Employee["Name"].ToString();
                }
            }
            
            
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHouses_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmAgentHouses f = new frmAgentHouses();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmHome f = new frmHome();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmAgentClients f = new frmAgentClients();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
