using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;



namespace WindowsFormsAppRemaxProject
{
    public partial class frmAdmin : Form
    {
       
        
        public frmAdmin()
        {
            InitializeComponent();

            pnlDesktop.Controls.Clear();
            frmHome f = new frmHome();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
            
            //get the user and set his name in lable
            if(LoginPage.Ep.Rows[0][1].ToString() != null)
            {
                string tempName = LoginPage.Ep.Rows[0][1].ToString();
                if (tempName != null)
                {
                    lblUserName.Text = tempName;
                }
            
            }
            

        }

       

        private void btnHouses_Click(object sender, EventArgs e)
        {
            
            pnlDesktop.Controls.Clear();
            frmAdminHouses f = new frmAdminHouses();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmAdminClients f = new frmAdminClients();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmAdminEmployees f = new frmAdminEmployees();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void UserStatus_TextChanged(object sender, EventArgs e)
        {
            
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
