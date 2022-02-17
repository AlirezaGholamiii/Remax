using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsBranche
    {
        private string vNumber;
        private string vCompany;
        private string vLocation;
        private string vStatus;
        private clsListClientBuyer vClientBuyer;
        private clsListClientSeller vClientSeller;
        private clsListHouse vHouse;
        private clsListAgent vAgente;
        private clsListManager vManager;

        public clsBranche()
        {
            vNumber = vCompany = vLocation = vStatus = "Not defined";
            vClientBuyer = new clsListClientBuyer();
            vClientSeller = new clsListClientSeller();
            vHouse = new clsListHouse();
            vAgente = new clsListAgent();
            vManager = new clsListManager();
        }

        public clsBranche(string number, string company, string location, string status, clsListClientBuyer clientsBuyer, clsListClientSeller clientsSeller, clsListAgent agent , clsListManager manager, clsListHouse houses)
        {
            vNumber = number;
            vCompany = company;
            vLocation = location;
            vStatus = status;
            vClientBuyer = clientsBuyer;
            vClientSeller = clientsSeller;
            vHouse = houses;
            vAgente = agent;
            vManager = manager;


        }
        public clsBranche(string number, string company, string location, string status)
        {
            vNumber = number;
            vCompany = company;
            vLocation = location;
            vStatus = status;
            vClientBuyer = new clsListClientBuyer();
            vClientSeller = new clsListClientSeller();
            vHouse = new clsListHouse();
            vAgente = new clsListAgent();
            vManager = new clsListManager();

        }

        public string Number
        {
            get => vNumber;
            set
            {
                vNumber = value;
            }
        }

        public string Company
        {
            get => vCompany;
            set
            {
                vCompany = value;
            }
        }

        public string Location
        {
            get => vLocation;
            set
            {
                vLocation = value;
            }
        }

        public string Status
        {
            get => vStatus;
            set
            {
                vStatus = value;
            }
        }

        public clsListClientBuyer ClientsBuyer
        {
            get => vClientBuyer;
            set
            {
                vClientBuyer = value;
            }
        }

        public clsListClientSeller ClientsSeller
        {
            get => vClientSeller;
            set
            {
                vClientSeller = value;
            }
        }

        public clsListHouse Houses
        {
            get => vHouse;
            set
            {
                vHouse = value;
            }
        }

        public clsListManager Managers
        {
            get => vManager;
            set
            {
                vManager = value;
            }
        }

        public clsListAgent Agents
        {
            get => vAgente;
            set
            {
                vAgente = value;
            }
        }


        public void Close()
        {
            vStatus = "closed";
        }

        
    }

}
