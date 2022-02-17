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
    public partial class frmAgentHouses : Form
    {
        DataTable tabEmployees, tabBranch, tabHouses, tabHouseFeatures, tabClients;
        DataGridViewCell cell = null;
        int CurrentRow;
        string mode = "";
        int rowsR;

        

        public frmAgentHouses()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            ButtonActivation(false, true, true, true, true, false, false, false, false, false, true, true, true, true, true, true, true, false, false, false, true, true);
            txtHouseID.Text = txtEmployeeID.Text = cboClientName.Text = txtClientID.Text = cmbEmployeeName.Text = txtNeighbourhood.Text = txtBed.Text = txtPrice.Text = txtBuilt.Text = txtDescription.Text = txtAdress.Text = " ";
            txtHouseID.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            ButtonActivation(false, true, true, true, true, false, false, false, false, false, true, true, true, true, true, true, true, false, false, false, true, true);
            cboClientName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentEstate = Convert.ToInt32(txtHouseID.Text);
            if (MessageBox.Show("Are you sure to delete this company ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete the record(or datarow) positioned at the currentindex
                tabHouses.Rows[CurrentRow].Delete();
                tabHouseFeatures.Rows[CurrentRow].Delete();



                //========= Delete from House table =========//
                // Save (or synchronize) the contents of the myset.tabels["Houses"] to the database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");
                // Refresh the datatable with the content of the database in case of changes
                clsGlobal.mySet.Tables.Remove("Houses");
                clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "Houses");

                //========= Delete from House Feature table =========//
                // Save (or synchronize) the contents of the myset.tabels["HouseFeature"] to the database
                myBuilder = new SqlCommandBuilder(clsGlobal.adpHouseFeatures);
                clsGlobal.adpHouseFeatures.Update(clsGlobal.mySet, "HouseFeatures");
                // Refresh the datatable with the content of the database in case of changes
                clsGlobal.mySet.Tables.Remove("HouseFeatures");
                clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "HouseFeatures");


                // To show first itm in the text boxes
                if(dataAllHouses.Rows != null)
                {
                    dataAllHouses.Rows[0].Selected = true;
                }
                else
                {
                    return;
                }
                


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow myHouse, myHouseFeature;
            int EstateCheck = Convert.ToInt32(txtHouseID.Text);
            if (mode == "add")
            {


                try
                {

                    if (txtHouseID.Text != " ")
                    {



                        //Add info to table Houses
                        myHouse = tabHouses.NewRow();
                        myHouse["EstateID"] = txtHouseID.Text;
                        myHouse["Status"] = cboStatus.Text;
                        myHouse["ClientID"] = txtClientID.Text;
                        myHouse["EmployeeID"] = txtEmployeeID.Text;
                        myHouse["BranchID"] = txtBranchID.Text;


                        //Add info to table HouseFeature
                        myHouseFeature = tabHouseFeatures.NewRow();
                        myHouseFeature["EstateID"] = txtHouseID.Text;
                        myHouseFeature["Building Type"] = cmbType.Text;
                        myHouseFeature["BedRooms"] = txtBed.Text;
                        myHouseFeature["Built in"] = txtBuilt.Text;
                        myHouseFeature["Neighbourhood"] = txtNeighbourhood.Text;
                        myHouseFeature["Address"] = txtAdress.Text;
                        myHouseFeature["Price"] = txtPrice.Text;
                        myHouseFeature["Description"] = txtDescription.Text;
                        myHouseFeature["Pool"] = cboPool.Text;
                        myHouseFeature["Elevator"] = cboElevator.Text;



                        //======= Save record on thable Houses =======//
                        //check if number is not exist in list
                        try
                        {
                            tabHouses.Rows.Add(myHouse); // Save the record in the table
                            SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                            clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");
                            // Refresh the datatable with the content of the database in case of changes
                            clsGlobal.mySet.Tables.Remove("Houses");
                            clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");

                            //======= Save record on thable HouseFeatures =======//

                            tabHouseFeatures.Rows.Add(myHouseFeature); // Save the record in the table
                            myBuilder = new SqlCommandBuilder(clsGlobal.adpHouseFeatures);
                            clsGlobal.adpHouseFeatures.Update(clsGlobal.mySet, "HouseFeatures");
                            // Refresh the datatable with the content of the database in case of changes
                            clsGlobal.mySet.Tables.Remove("HouseFeatures");
                            clsGlobal.adpHouseFeatures.Fill(clsGlobal.mySet, "HouseFeatures");
                        }
                        catch
                        {
                            MessageBox.Show("This House ID is already exist", "Adding Fails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtHouseID.Focus();
                            return;
                        }




                    }


                }
                catch
                {
                    MessageBox.Show("Please fill all the textboxes and make sure they are in the correct format.", "Empty Fields Or Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else// mode == Edit
            {


                DataRow MyHouse = tabHouses.Rows[CurrentRow];
                DataRow MyHouseFeature = tabHouseFeatures.Rows[CurrentRow];



                //Edit info to table Houses


                MyHouse["Status"] = cboStatus.Text;
                MyHouse["ClientID"] = txtClientID.Text;
                MyHouse["EmployeeID"] = txtEmployeeID.Text;
                MyHouse["BranchID"] = txtBranchID.Text;


                //Edit info to table HouseFeature

                MyHouseFeature["Building Type"] = cboType.Text;
                MyHouseFeature["BedRooms"] = txtBed.Text;
                MyHouseFeature["Built in"] = txtBuilt.Text;
                MyHouseFeature["Neighbourhood"] = txtNeighbourhood.Text;
                MyHouseFeature["Address"] = txtAdress.Text;
                MyHouseFeature["Price"] = txtPrice.Text;
                MyHouseFeature["Description"] = txtDescription.Text;
                MyHouseFeature["Pool"] = cboPool.Text;
                MyHouseFeature["Elevator"] = cboElevator.Text;



                // ======== Final save edit on the table House ======== //

                // tabHouses.Rows.Add(MyHouse); // Save the record in the table
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");
                // Refresh the datatable with the content of the database in case of changes
                clsGlobal.mySet.Tables.Remove("Houses");
                clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");



                //======= Save record on thable HouseFeatures =======//

                SqlCommandBuilder myBuilderr = new SqlCommandBuilder(clsGlobal.adpHouseFeatures);
                clsGlobal.adpHouseFeatures.Update(clsGlobal.mySet, "HouseFeatures");
                // Refresh the datatable with the content of the database in case of changes
                clsGlobal.mySet.Tables.Remove("HouseFeatures");
                clsGlobal.adpHouseFeatures.Fill(clsGlobal.mySet, "HouseFeatures");
            }

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonActivation(true, false, true, false, true, true, true, true, true, true, false, false, false, false, true, false, false, true, true, true, false, false);
            txtHouseID.Text = txtEmployeeID.Text = cboClientName.Text = txtClientID.Text = cmbEmployeeName.Text = txtNeighbourhood.Text = txtBed.Text = txtPrice.Text = txtBuilt.Text = txtDescription.Text = txtAdress.Text = " ";
            txtHouseID.Focus();
            dataAllHouses.Rows[0].Selected = true;
        }

        public class House
        {
            private int estateId;
            private string buildingType;
            private int bedroom;
            private string builtIn;
            private string neighbour;
            private string address;
            private int price;
            private string description;
            private string pool;
            private string elevator;

           
            public int EstateID { get => estateId; set => estateId = value; }
            public string BuildingType { get => buildingType; set => buildingType = value; }
            public int Bedrooms { get => bedroom; set => bedroom = value; }
            public string BuiltIn { get => builtIn; set => builtIn = value; }
            public string Neighbourhood { get => neighbour; set => neighbour = value; }
            public string Address { get => address; set => address = value; }
            public int Price { get => price; set => price = value; }
            public string Description { get => description; set => description = value; }
            public string Pool { get => pool; set => pool = value; }
            public string Elevator { get => elevator; set => elevator = value; }

            
            public static List<House> HouseGetRecordList(int rows)
            {
                List<House> listHouse = new List<House>();
                {
                    House hos;
                    SqlCommand cmdSelectCust = new SqlCommand("SELECT * FROM HouseFeatures WHERE EstateID = '" + rows + "' ", clsGlobal.myCon);
                    SqlDataReader sqlReader = cmdSelectCust.ExecuteReader();
                    

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            hos = new House();
                            hos.EstateID = Convert.ToInt32(sqlReader["EstateID"]);
                            hos.BuildingType = sqlReader["Building Type"].ToString();
                            hos.Bedrooms = Convert.ToInt32(sqlReader["BedRooms"]);
                            hos.BuiltIn = sqlReader["Built in"].ToString();
                            hos.Neighbourhood = sqlReader["Neighbourhood"].ToString();
                            hos.Address = sqlReader["Address"].ToString();
                            hos.Price = Convert.ToInt32(sqlReader["Price"]);
                            hos.Description = sqlReader["Description"].ToString();
                            hos.Pool = sqlReader["Pool"].ToString();
                            hos.Elevator = sqlReader["Elevator"].ToString();
                            listHouse.Add(hos);
                        }
                    }
                    else
                    {
                        listHouse = null;
                    }
                    sqlReader.Close();
                }
                return listHouse;
            }

            public List<House> GetHouseList(int rows)
            {
                return HouseGetRecordList(rows);
            }

        }

        private void ButtonActivation(bool HoseID, bool EmployeeName, bool EmployeeID, bool ClientNamee, bool ClientID, bool Neighbourhood, bool Bed, bool Price, bool Adress,
            bool Description, bool Status, bool BuiltIn, bool Typee, bool BranchNamee, bool branchID, bool Pool, bool elavator, bool Add, bool Edit, bool Delete, bool Save, bool Cancel)
        {
            txtHouseID.ReadOnly = HoseID;
            cmbEmployeeName.Enabled = EmployeeName;
            cboClientName.Enabled = ClientNamee;
            txtClientID.ReadOnly = ClientID;
            txtEmployeeID.ReadOnly = EmployeeID;
            txtNeighbourhood.ReadOnly = Neighbourhood;
            txtBed.ReadOnly = Bed;
            txtPrice.ReadOnly = Price;
            txtAdress.ReadOnly = Adress;
            txtDescription.ReadOnly = Description;
            cboStatus.Enabled = Status;
            txtBuilt.Enabled = BuiltIn;
            cmbType.Enabled = Typee;
            cmbBranchName.Enabled = BranchNamee;
            txtBranchID.ReadOnly = branchID;
            cboPool.Enabled = Pool;
            cboElevator.Enabled = elavator;
            btnAdd.Enabled = Add;
            btnEdit.Enabled = Edit;
            btnDelete.Enabled = Delete;
            btnSave.Enabled = Save;
            btnCancel.Enabled = Cancel;

        }
       

        private void frmAgentHouses_Load(object sender, EventArgs e)
        {
            ButtonActivation(true, false, true, false, true, true, true, true, true, true, false, false, false, false, true, false, false, true, true, true, false, false);
            tabHouseFeatures = clsGlobal.mySet.Tables["HouseFeatures"];
            tabHouses = clsGlobal.mySet.Tables["Houses"];
            tabBranch = clsGlobal.mySet.Tables["Branches"];
            tabClients = clsGlobal.mySet.Tables["Clients"];
            tabEmployees = clsGlobal.mySet.Tables["Employees"];


            foreach(DataRow Employee in tabEmployees.Rows)
            {
                if(Employee["EmployeeID"].ToString() == LoginPage.currentAgent.ToString())
                {
                    cmbEmployeeName.Text = Employee["Name"].ToString();
                    txtEmployeeID.Text = LoginPage.currentAgent.ToString();
                }
            }

             



            //Finding numbers of houses belong to a Empolyee
            List<object> list8 = new List<object>();
            foreach (DataRow House in tabHouses.Rows)
             {
                 if(House["EmployeeID"].ToString() == LoginPage.currentAgent)
                {
                    foreach(DataRow HouseF in tabHouseFeatures.Rows)
                    {
                        if (House["EstateID"].ToString() == HouseF["EstateID"].ToString())
                        {
                            list8.Add(Convert.ToInt32(HouseF["EstateID"]));
                            rowsR = Convert.ToInt32(HouseF["EstateID"]);
                           
                        }
                    }

                    cboNeighbourhood.Items.Clear();
                    cboNeighbourhood.Items.AddRange(list8.ToArray());
                }
             }

            foreach(DataRow HouseFuture in tabHouseFeatures.Rows)
            {
                if(HouseFuture["EstateID"].ToString() == list8.ToArray().ToString())
                {
                    dataAllHouses.DataSource = HouseFuture["EstateID"];
                }
            }



            dataAllHouses.Refresh();
            foreach(int x in list8)
            {
                House hos = new House();
                dataAllHouses.DataSource = hos.GetHouseList(x);
                
            }
            




            foreach (DataRow myRow in tabHouseFeatures.Rows)
            {
                //fill cbo type in search box and avoiding to shoe repeated item
                cmbType.Items.Add(myRow["Building Type"]).ToString().Distinct();
                List<object> list = new List<object>();
                foreach (object o in cmbType.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbType.Items.Clear();
                cmbType.Items.AddRange(list.ToArray());


                //Fill the combo box pool
                cboPool.Items.Add(myRow["Pool"]).ToString().Distinct();
                List<object> list1 = new List<object>();
                foreach (object o in cboPool.Items)
                {
                    if (!list1.Contains(o))
                    {
                        list1.Add(o);
                    }
                }
                cboPool.Items.Clear();
                cboPool.Items.AddRange(list1.ToArray());
                cmbType.SelectedIndex = 0;

                //fill the combo box Elevator
                cboElevator.Items.Add(myRow["Elevator"]).ToString().Distinct();
                List<object> list2 = new List<object>();
                foreach (object o in cboElevator.Items)
                {
                    if (!list2.Contains(o))
                    {
                        list2.Add(o);
                    }
                }
                cboElevator.Items.Clear();
                cboElevator.Items.AddRange(list2.ToArray());
                cboElevator.SelectedIndex = 0;
            }


        }




        private void dataAllHouses_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell selectCell in dataAllHouses.SelectedCells)
            {
                cell = selectCell;

                break;
            }
            try
            {


                if (cell != null)
                {
                    DataGridViewRow myRow = cell.OwningRow;

                    txtHouseID.Text = myRow.Cells["EstateID"].Value.ToString();
                    txtNeighbourhood.Text = myRow.Cells["Neighbourhood"].Value.ToString();
                    txtBed.Text = myRow.Cells["BedRooms"].Value.ToString();
                    txtPrice.Text = myRow.Cells["Price"].Value.ToString();
                    txtBuilt.Text = myRow.Cells["Built in"].Value.ToString();
                    cmbType.Text = myRow.Cells["Building Type"].Value.ToString();
                    cboPool.Text = myRow.Cells["Pool"].Value.ToString();
                    cboElevator.Text = myRow.Cells["Elevator"].Value.ToString();
                    txtAdress.Text = myRow.Cells["Address"].Value.ToString();
                    txtDescription.Text = myRow.Cells["Description"].Value.ToString();
                    


                    // Get client name from Client table
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            foreach (DataRow Clients in tabClients.Rows)
                            {
                                if (Clients["ClientID"].ToString() == Houses["ClientID"].ToString())
                                {
                                    cboClientName.Text = Clients["ClientName"].ToString();
                                    txtClientID.Text = Clients["ClientID"].ToString();
                                }
                            }
                        }
                    }


                    // Get employee name from table Employees
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            foreach (DataRow Employees in tabEmployees.Rows)
                            {
                                if (Employees["EmployeeID"].ToString() == Houses["EmployeeID"].ToString())
                                {
                                    cmbEmployeeName.Text = Employees["Name"].ToString();
                                }
                            }
                        }
                    }


                    //house status
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            cboStatus.Text = Houses["Status"].ToString();
                            txtBranchID.Text = Houses["BranchID"].ToString();

                        }
                    }

                    //branch name 
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            foreach (DataRow branch in tabBranch.Rows)
                            {
                                if (Houses["BranchID"].ToString() == branch["BranchID"].ToString())
                                {
                                    cmbBranchName.SelectedItem = branch["Location"].ToString();
                                }
                            }
                        }
                    }


                    CurrentRow = dataAllHouses.CurrentRow.Index;
                }
            }
            catch
            {

                //dataAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];
                //datagridAllHouses.Rows[0].Selected = true;
            }
        }
    }
}
