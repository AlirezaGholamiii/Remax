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
    public partial class frmGuest : Form
    {
        public frmGuest()
        {
            InitializeComponent();
            pnlDesktop.Controls.Clear();
            frmHome f = new frmHome();
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

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmGuestEmployee f = new frmGuestEmployee();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(f);
            f.Show();
        }

        private void btnHouses_Click(object sender, EventArgs e)
        {
            pnlDesktop.Controls.Clear();
            frmGuestHouses f = new frmGuestHouses();
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
