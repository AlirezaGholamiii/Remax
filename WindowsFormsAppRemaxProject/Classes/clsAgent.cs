using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsAgent
    {

        private string vEmployeeID;
        private string vName;
        private string vPosition;
        private string vPhone;
        private string vPin;
        private string vCity;
        private DateTime vBirthday;
        private clsListClientBuyer vClientBuyer;
        private clsListClientSeller vClientSeller;
        private clsListHouse vHouse;

        public clsAgent()
        {
            vEmployeeID = vName = vPosition = vPhone = vPin = vCity = "Not Defined";
            vBirthday = new DateTime();
            vClientBuyer = new clsListClientBuyer();
            vClientSeller = new clsListClientSeller();
            vHouse = new clsListHouse();
        }


        public clsAgent(string employeeID, string name, string position, string phone, string pin, string city, DateTime birthday, clsListClientBuyer clientsBuyer, clsListClientSeller clientsSeller, clsListHouse houses)
        {
            vEmployeeID = employeeID;
            vName = name;
            vPosition = position;
            vPhone = phone;
            vPin = pin;
            vCity = city;
            vBirthday = birthday;
            vClientBuyer = clientsBuyer;
            vClientSeller = clientsSeller;
            vHouse = houses;

        }

        public clsAgent(string employeeID, string name, string position, string phone, string pin, string city)
        {
            vEmployeeID = employeeID;
            vName = name;
            vPosition = position;
            vPhone = phone;
            vPin = pin;
            vCity = city;
            vBirthday = new DateTime();
            vClientBuyer = new clsListClientBuyer();
            vClientSeller = new clsListClientSeller();
            vHouse = new clsListHouse();
        }

        public string EmployeeID
        {
            get => vEmployeeID;
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string Position
        {
            get => vPosition;
            set
            {
                vPosition = value;
            }
        }

        public string Phone
        {
            get => vPhone;
            set
            {
                vPhone = value;
            }
        }

        public string Pin
        {
            get => vPin;
            set
            {
                vPin = value;
            }
        }

        public string City
        {
            get => vCity;

            set
            {
                vCity = value;
            }
        }

        public DateTime Birthday
        {
            get => vBirthday;

            set
            {
                vBirthday = value;
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

        public void Register(string employeeID, string name, string position, string phone, string pin, string city)
        {
            vEmployeeID = employeeID;
            Name = name;
            Position = position;
            Phone = phone;
            Pin = pin;
            City = city;


        }
    }
}
