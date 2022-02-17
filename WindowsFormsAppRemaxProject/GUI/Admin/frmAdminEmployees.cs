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
    public partial class frmAdminEmployees : Form
    {
        

        DataTable tabEmployees, tabBranch;
        DataGridViewCell cell = null;
        int CurrentRow;
        string mode;

        public frmAdminEmployees()
        {
            InitializeComponent();
        }

        private void ButtonActivation(bool EmpolyeeID, bool EmployeeName, bool EmployeePosition, bool EmployeePhone, bool Birthdate, bool Gender,
            bool Email, bool City, bool Username, bool Pin, bool BranchID, bool BranchName, bool Add, bool Edit, bool Delete, bool Save, bool Cancel)
        {
            txtEmpolyeeID.ReadOnly = EmpolyeeID;
            txtEmployeeName.ReadOnly = EmployeeName;
            cmbEmployeePosition.Enabled = EmployeePosition;
            txtEmployeePhone.ReadOnly = EmployeePhone;
            EmployeeBirthdate.Enabled = Birthdate;
            txtGender.ReadOnly = Gender;
            txtEmail.ReadOnly = Email;
            txtCity.ReadOnly = City;
            txtUsername.ReadOnly = Username;
            txtPin.ReadOnly = Pin;
            txtBranchID.ReadOnly = BranchID;
            cmbBranchName.Enabled = BranchName;
            btnAdd.Enabled = Add;
            btnEdit.Enabled = Edit;
            btnDelete.Enabled = Delete;
            btnSave.Enabled = Save;
            btnCancel.Enabled = Cancel;

        }





        private void frmAdminEmployees_Load(object sender, EventArgs e)
        {


            ButtonActivation(true, true, false, true, false, true, true, true, true, true, true, false, true, true, true, false, false);

            tabEmployees = clsGlobal.mySet.Tables["Employees"];


            //Fill the grid veiw with data
            dataGridAllEmployees.DataSource = clsGlobal.mySet.Tables["Employees"];




            //fill the House status combobox with company name
            foreach (DataRow myRow in tabEmployees.Rows)
            {
                cmbEmployeePosition.Items.Add(myRow["Position"]).ToString().Distinct();

                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cmbEmployeePosition.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbEmployeePosition.Items.Clear();
                cmbEmployeePosition.Items.AddRange(list.ToArray());


                //fill cbo Position in search box and avoiding to shoe repeated item
                cboPosition.Items.Add(myRow["Position"]).ToString().Distinct();
                
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

            //fill Location combo box with first element
            if (cmbEmployeePosition == null)
            {
                cmbEmployeePosition.SelectedIndex = 0;
            }



            //fill the combobox with company branches
            foreach (DataRow myRow in tabBranch.Rows)
            {
                cmbBranchName.Items.Add(myRow["Location"]).ToString().Distinct();
                cboBranch.Items.Add(myRow["Location"]).ToString().Distinct();
                //Avoid repeating item
                List<object> list = new List<object>();
                foreach (object o in cmbBranchName.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbBranchName.Items.Clear();
                cmbBranchName.Items.AddRange(list.ToArray());

            }

            //fill combo box with first element

            cmbBranchName.SelectedIndex = 0;
            cboBranch.SelectedIndex = 0;
            cboPosition.SelectedIndex = 0;






        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            ButtonActivation(false, false, true, false, true, false, false, false, false, false, true, true, false, false, false, true, true);
            txtEmpolyeeID.Text = txtEmployeeName.Text = txtEmployeePhone.Text = txtGender.Text = txtEmail.Text = txtCity.Text = txtUsername.Text = txtPin.Text = "";

            EmployeeBirthdate.Text = DateTime.Today.ToString();

            txtEmployeeName.Focus();

        }

        private void cmbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow Branch in tabBranch.Rows)
            {


                if (cmbBranchName.SelectedItem.ToString() == Branch["Location"].ToString())
                {
                    txtBranchID.Text = Branch["BranchID"].ToString();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            ButtonActivation(true, false, true, false, true, false, false, false, false, false, true, true, false, false, false, true, true);
            txtEmployeeName.Focus();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {





            if (MessageBox.Show("Are you sure to delete this company ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete the record(or datarow) positioned at the currentindex
                tabEmployees.Rows[CurrentRow].Delete();

                // Save (or synchronize) the contents of the myset.tabels["Companies"] to the database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpEmployees);
                clsGlobal.adpEmployees.Update(clsGlobal.mySet, "Employees");
                // Refresh the datatable with the content of the database in case of changes
                clsGlobal.mySet.Tables.Remove("Employees");
                clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "Employees");
                dataGridAllEmployees.Rows[0].Selected = true;
                CurrentRow = 0;

                txtEmpolyeeID.Text = tabEmployees.Rows[CurrentRow]["EmployeeID"].ToString();
                txtEmployeeName.Text = tabEmployees.Rows[CurrentRow]["Name"].ToString();
                cmbEmployeePosition.Text = tabEmployees.Rows[CurrentRow]["Position"].ToString();
                txtEmployeePhone.Text = tabEmployees.Rows[CurrentRow]["Phone"].ToString();
                EmployeeBirthdate.Text = tabEmployees.Rows[CurrentRow]["Birthday"].ToString();
                txtGender.Text = tabEmployees.Rows[CurrentRow]["Gender"].ToString();
                txtEmail.Text = tabEmployees.Rows[CurrentRow]["Email"].ToString();
                txtCity.Text = tabEmployees.Rows[CurrentRow]["City"].ToString();
                txtUsername.Text = tabEmployees.Rows[CurrentRow]["Username"].ToString();
                txtPin.Text = tabEmployees.Rows[CurrentRow]["Pin"].ToString();
                txtBranchID.Text = tabEmployees.Rows[CurrentRow]["BranchID"].ToString();
                //To fill Branch name combo box by using branchID
                tabBranch = clsGlobal.mySet.Tables["Branches"];

                foreach (DataRow Branch in tabBranch.Rows)
                {
                    if (tabEmployees.Rows[CurrentRow]["BranchID"].ToString() == Branch["BranchID"].ToString())
                    {
                        cmbBranchName.Text = Branch["Location"].ToString();
                    }
                }



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow myRow;
            if (mode == "add")
            {
                //check if number is not exist in list

                try
                {
                    foreach (DataRow mr in tabEmployees.Rows)
                    {
                        if (txtEmpolyeeID.Text == mr["EmployeeID"].ToString())
                        {
                            MessageBox.Show("This Employee ID is already exist", "Adding Fails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmpolyeeID.Focus();
                            return;
                        }

                    }



                    myRow = tabEmployees.NewRow();

                    myRow["EmployeeID"] = txtEmpolyeeID.Text;
                    myRow["Name"] = txtEmployeeName.Text;
                    myRow["Position"] = cmbEmployeePosition.Text;
                    myRow["Phone"] = txtEmployeePhone.Text;
                    myRow["Birthday"] = EmployeeBirthdate.Text;
                    myRow["Gender"] = txtGender.Text;
                    myRow["Email"] = txtEmail.Text;
                    myRow["City"] = txtCity.Text;
                    myRow["Username"] = txtUsername.Text;
                    myRow["Pin"] = txtPin.Text;
                    myRow["BranchID"] = txtBranchID.Text;
                    myRow["Phone"] = txtEmployeePhone.Text;

                    //To fill Branch name combo box by using branchID
                    tabBranch = clsGlobal.mySet.Tables["Branches"];

                    foreach (DataRow Branch in tabBranch.Rows)
                    {
                        if (tabEmployees.Rows[CurrentRow]["BranchID"].ToString() == Branch["BranchID"].ToString())
                        {
                            cmbBranchName.Text = Branch["Location"].ToString();
                        }
                    }

                    tabEmployees.Rows.Add(myRow); // Save the record in the table
                  
                    // Save (or synchronize) the contents of the myset.tabels["Employees"] to the database
                    SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpEmployees);
                    clsGlobal.adpEmployees.Update(clsGlobal.mySet, "Employees");
                    // Refresh the datatable with the content of the database in case of changes
                    clsGlobal.mySet.Tables.Remove("Employees");
                    clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "Employees");

                }
                catch
                {
                    MessageBox.Show("Please fill all the textboxes.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else// mode == Edit
            {
                myRow = tabEmployees.Rows[CurrentRow];

                myRow["Name"] = txtEmployeeName.Text;
                myRow["Position"] = cmbEmployeePosition.Text;
                myRow["Phone"] = txtEmployeePhone.Text;
                myRow["Birthday"] = EmployeeBirthdate.Text;
                myRow["Gender"] = txtGender.Text;
                myRow["Email"] = txtEmail.Text;
                myRow["City"] = txtCity.Text;
                myRow["Username"] = txtUsername.Text;
                myRow["Pin"] = txtPin.Text;
                myRow["BranchID"] = txtBranchID.Text;
                myRow["Phone"] = txtEmployeePhone.Text;

                txtEmpolyeeID.Enabled = true;
                // Save (or synchronize) the contents of the myset.tabels["Companies"] to the database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpEmployees);
                clsGlobal.adpEmployees.Update(clsGlobal.mySet, "Employees");
                // Refresh the datatable with the content of the database in case of changes
                clsGlobal.mySet.Tables.Remove("Employees");
                clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "Employees");
            }

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        //Search button
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (txtSearchID.Text != " ")
            {
                /*string cmd = "SELECT * FROM Employees WHERE EmployeeID = @EmpID";
                clsGlobal.myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Remax;Integrated Security=True");
                clsGlobal.myCon.Open();

                clsGlobal.myCmd = new SqlCommand(cmd, clsGlobal.myCon);
                clsGlobal.myCmd.Parameters.AddWithValue("@EmpID", txtSearchID.Text);

                SqlDataReader empReader = clsGlobal.myCmd.ExecuteReader(CommandBehavior.SingleRow);
                if(empReader.Read())
                {

                }*/

                foreach(DataRow myrow in tabEmployees.Rows)
                {
                    if(myrow["EmployeeID"].ToString() == txtSearchID.Text)
                    {
                        dataGridAllEmployees.DataSource = myrow;
                    }
                }
            }
            else if(txtSearchID.Text == " ")
            {
                MessageBox.Show("Please Enter Your Employee ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchID.Focus();
            }

        }

        private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow Branch in tabBranch.Rows)
            {


                if (cboBranch.SelectedItem.ToString() == Branch["Location"].ToString())
                {
                    txtBranchID.Text = Branch["BranchID"].ToString();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonActivation(true, true, false, true, false, true, true, true, true, true, true, false, true, true, true, false, false);

            txtEmpolyeeID.Text = txtEmployeeName.Text = txtEmployeePhone.Text = txtGender.Text = txtEmail.Text = txtCity.Text = txtUsername.Text = txtPin.Text = "";
            EmployeeBirthdate.Text = DateTime.Today.ToString();

        }


        private void dataGridAllEmployees_SelectionChanged(object sender, EventArgs e)
        {

            

            foreach (DataGridViewCell selectCell in dataGridAllEmployees.SelectedCells)
            {
                cell = selectCell;
                
                break;
            }
            try
            {


                if (cell != null)
                {
                    DataGridViewRow myRow = cell.OwningRow;

                    txtEmpolyeeID.Text = myRow.Cells["EmployeeID"].Value.ToString();
                    txtEmployeeName.Text = myRow.Cells["Name"].Value.ToString();
                    cmbEmployeePosition.Text = myRow.Cells["Position"].Value.ToString();
                    txtEmployeePhone.Text = myRow.Cells["Phone"].Value.ToString();
                    EmployeeBirthdate.Text = myRow.Cells["Birthday"].Value.ToString();
                    txtGender.Text = myRow.Cells["Gender"].Value.ToString();
                    txtEmail.Text = myRow.Cells["Email"].Value.ToString();
                    txtCity.Text = myRow.Cells["City"].Value.ToString();
                    txtUsername.Text = myRow.Cells["Username"].Value.ToString();
                    txtPin.Text = myRow.Cells["Pin"].Value.ToString();
                    txtBranchID.Text = myRow.Cells["BranchID"].Value.ToString();

                    //To fill Branch name combo box by using branchID
                    tabBranch = clsGlobal.mySet.Tables["Branches"];

                    foreach (DataRow Branch in tabBranch.Rows)
                    {
                        if (myRow.Cells["BranchID"].Value.ToString() == Branch["BranchID"].ToString())
                        {
                            cmbBranchName.Text = Branch["Location"].ToString();
                        }
                    }

                    
                    CurrentRow = dataGridAllEmployees.CurrentRow.Index;
                }
            }
            catch
            {
                
                dataGridAllEmployees.DataSource = clsGlobal.mySet.Tables["Employees"];
                dataGridAllEmployees.Rows[0].Selected = true;
            }
            
        }
    }
}
