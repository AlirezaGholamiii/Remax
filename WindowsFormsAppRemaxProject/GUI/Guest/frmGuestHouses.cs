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
    public partial class frmGuestHouses : Form
    {
        public frmGuestHouses()
        {
            InitializeComponent();
        }
        DataTable  tabHouseFeatures;
        private void frmGuestHouses_Load(object sender, EventArgs e)
        {
            tabHouseFeatures = clsGlobal.mySet.Tables["HouseFeatures"];
            datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];



            //fill the combobox with Bedrooms 
            foreach (DataRow myRow in tabHouseFeatures.Rows)
            {
                cboBedrooms.Items.Add(myRow["BedRooms"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cboBedrooms.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboBedrooms.Items.Clear();
                cboBedrooms.Items.AddRange(list.ToArray());

            }
            cboBedrooms.SelectedIndex = 0;

            //fill the combobox with  Neighbourhood
            foreach (DataRow myRow in tabHouseFeatures.Rows)
            {
                cboNeighbourhood.Items.Add(myRow["Neighbourhood"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cboNeighbourhood.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboNeighbourhood.Items.Clear();
                cboNeighbourhood.Items.AddRange(list.ToArray());

            }
            cboNeighbourhood.SelectedIndex = 0;

            //fill the combobox with  Neighbourhood
            foreach (DataRow myRow in tabHouseFeatures.Rows)
            {
                cboType.Items.Add(myRow["Building Type"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cboType.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboType.Items.Clear();
                cboType.Items.AddRange(list.ToArray());

            }
            cboType.SelectedIndex = 0;

            //fill the combobox with  Price
            foreach (DataRow myRow in tabHouseFeatures.Rows)
            {
                cboPrice.Items.Add(myRow["Price"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cboPrice.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboPrice.Items.Clear();
                cboPrice.Items.AddRange(list.ToArray());

            }
            cboPrice.SelectedIndex = 0;
        }

        private void checkNeighbourhood_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkNeighbourhood.Checked)
            {
                foreach (DataRow House in tabHouseFeatures.Rows)
                {
                    if (cboNeighbourhood.Text.ToString() == House["Neighbourhood"].ToString())
                    {
                        datagridAllHouses.DataSource = House["EstateID"];
                    }
                }
            }
            else
            {
                datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];
            }
        }

 
        private void checkBedrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBedrooms.Checked)
            {
                foreach (DataRow House in tabHouseFeatures.Rows)
                {
                    if (cboBedrooms.Text.ToString() == House["BedRooms"].ToString())
                    {
                        
                       
                        datagridAllHouses.DataSource = House["BedRooms"];
                    }
                }
            }
            else
            {
                datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];
            }
        }

        private void checkPropertyType_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPropertyType.Checked)
            {
                foreach (DataRow House in tabHouseFeatures.Rows)
                {
                    if (cboType.Text.ToString() == House["Building Type"].ToString())
                    {

                        datagridAllHouses.DataSource = House["Building Type"];
                    }
                }
            }
            else
            {
                datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];
            }
        }

        private void checkPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrice.Checked)
            {
                foreach (DataRow House in tabHouseFeatures.Rows)
                {
                    if (cboPrice.Text.ToString() == House["Price"].ToString())
                    {

                        datagridAllHouses.DataSource = House["Price"];
                    }
                }
            }
            else
            {
                datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];
            }
        }
    }
}
