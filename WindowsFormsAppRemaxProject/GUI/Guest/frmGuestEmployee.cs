using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppRemaxProject
{
    public partial class frmGuestEmployee : Form
    {
        public frmGuestEmployee()
        {
            InitializeComponent();
        }

        DataTable tabEmployees;

        private void frmGuestEmployee_Load(object sender, EventArgs e)
        {
            tabEmployees = clsGlobal.mySet.Tables["Employees"];


            //Fill the grid veiw with data
            dataGridAllEmployees.DataSource = clsGlobal.mySet.Tables["Employees"];


            //fill the combobox with  Name
            foreach (DataRow myRow in tabEmployees.Rows)
            {
                cboName.Items.Add(myRow["Name"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cboName.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboName.Items.Clear();
                cboName.Items.AddRange(list.ToArray());

            }
            cboName.SelectedIndex = 0;




            //fill the combobox with  Name
            foreach (DataRow myRow in tabEmployees.Rows)
            {
                cboPosition.Items.Add(myRow["Position"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cboPosition.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboPosition.Items.Clear();
                cboPosition.Items.AddRange(list.ToArray());

            }
            cboPosition.SelectedIndex = 0;
        }

        private void checkName_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkName.Checked)
            {
                foreach (DataRow Emp in tabEmployees.Rows)
                {
                    if (cboName.Text.ToString() == Emp["Name"].ToString())
                    {
                      
                        dataGridAllEmployees.DataSource = Emp;
                    }
                }
            }
            else
            {
                dataGridAllEmployees.DataSource = clsGlobal.mySet.Tables["Employees"];
            }

        }

        private void checkPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPosition.Checked)
            {
                foreach (DataRow Emp in tabEmployees.Rows)
                {
                    if (cboName.Text.ToString() == Emp["Position"].ToString())
                    {

                        dataGridAllEmployees.DataSource = Emp;
                    }
                }
            }
            else
            {
                dataGridAllEmployees.DataSource = clsGlobal.mySet.Tables["Employees"];
            }
        }
    }
}
