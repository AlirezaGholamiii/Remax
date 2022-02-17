using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsListManager
    {
        // private or hidden dictionary to encapsulate our own list
        private Dictionary<string, clsManager> myListManager;
     

        public clsListManager()
        {
            myListManager = new Dictionary<string, clsManager>();

        }

        public int ManagerQuantity
        {
            get { return myListManager.Count; }
        }


        public Dictionary<string, clsManager>.ValueCollection ManagerElements
        {
            get => myListManager.Values;
        }


        public bool Add(clsManager Manager)
        {
            if (ExistManager(Manager.EmployeeID) == false)
            {
                myListManager.Add(Manager.EmployeeID, Manager);
                return true;
            }
            else { return false; }

        }


        public bool DeleteManager(string employeeID)
        {
            return myListManager.Remove(employeeID);
        }


        public clsManager FindManager(string employeeID)
        {
            if (ExistManager(employeeID) == true)
            {
                return myListManager[employeeID];
            }
            else { return null; }
        }


        public bool ExistManager(string employeeID)
        {
            return myListManager.ContainsKey(employeeID);
        }


    }
}
