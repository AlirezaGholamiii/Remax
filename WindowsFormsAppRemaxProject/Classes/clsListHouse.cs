using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsListHouse
    {

        // private or hidden dictionary to encapsulate our own list
        private Dictionary<string, clsHouse> myList;
        public clsListHouse()
        {
            myList = new Dictionary<string, clsHouse>();
        }

        public int Quantity
        {
            get { return myList.Count; }
        }

        public Dictionary<string, clsHouse>.ValueCollection Elements
        {
            get => myList.Values;
        }

        public bool Add(clsHouse house)
        {
            if (Exist(house.EstateID) == false)
            {
                myList.Add(house.EstateID, house);
                return true;
            }
            else { return false; }

        }

        public bool Delete(string EstateID)
        {
            return myList.Remove(EstateID);
        }

        public clsHouse Find(string EstateID)
        {
            if (Exist(EstateID) == true)
            {
                return myList[EstateID];
            }
            else { return null; }
        }

        public bool Exist(string EstateID)
        {
            return myList.ContainsKey(EstateID);
        }

        public string Display()
        {
            string info = "";
            foreach (clsHouse itm in myList.Values)
            {
                info += itm.Display() + "\n";
            }
            return info;
        }
    }
}
