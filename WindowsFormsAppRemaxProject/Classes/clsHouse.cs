using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsHouse
    {
        // declare the fields
        private string vEstateID;
        private string vStatus;
        private string vType;
        private int vBed;
        private DateTime vBuilt;
        private string vNeighbourhood;
        private string vAddress;
        private int vPrice;
        private string vDescription;


        // do not declare vAge because it does not store a value


        // ------------ PROPERTIES --------------------
        public string EstateID
        {
            get { return vEstateID; }
            set { vEstateID = value; }
        }
        public string Status
        {
            get { return vStatus; }
            set { vStatus = value; }
        }
        public string Type
        {
            get { return vType; }
            set { vType = value; }
        }
        public int Bed
        {
            get { return vBed; }
            set { vBed = value; }
        }
        public DateTime Built
        {
            get { return vBuilt; }
            set { vBuilt = value; }
        }
        public string Neighbourhood
        {
            get { return vNeighbourhood; }
            set { vNeighbourhood = value; }
        }
        public string Address
        {
            get { return vAddress; }
            set { vAddress = value; }
        }
        public int Price
        {
            get { return vPrice; }
            set { vPrice = value; }
        }
        public string Description
        {
            get { return vDescription; }
            set { vDescription = value; }
        }

       
        // -----------CONSTRUCTORS --------------
        public clsHouse()
        {
            vEstateID = vStatus = vType = vNeighbourhood = vAddress = vDescription = "Not defined";
            vBuilt = new DateTime();
            vPrice = -1;
            vBed = -1;
        }

        public clsHouse(string estateID, string status, string type, int bed , DateTime built , string neighbourhood , string address , int price , string description)
        {
            EstateID = estateID;
            Status = status;
            Type = type;
            Bed = bed;
            Built = built;
            Neighbourhood = neighbourhood;
            Address = address;
            Price = price;
            Description = description;
        }



        //--------------- METHODS --------------

        public void Sold()
        {
            vStatus = "Sold";
        }
        
        public void Bought()
        {
            vStatus = "Bought";
        }

        public void Rented()
        {
            vStatus = "Rented";
        }

        //for test
        public string Display()
        {
            string info = "Estate ID: " + EstateID + "\nStatus: " + Status + "\nType : " + Type;
            info += "\nBed Rooms : " + Bed + "\nBuilt In : " + Built + "\nNeighbourhood : " + Neighbourhood + "\nAddress : " + Address + "\nPrice : " + Price + "\nDescription : " + Description  ;
            return info;
        }
    }
}
