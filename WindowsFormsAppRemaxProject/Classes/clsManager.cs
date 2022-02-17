using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsManager
    {

        private string vEmployeeID;
        private string vName;
        private string vPosition;
        private string vPhone;
        private string vGender;
        private string vEmail;
        private string vUsername;
        private string vPin;
        private string vCity;
        private int vBranchID;
        private DateTime vBirthday;
        private clsListClientBuyer vClientBuyer;
        private clsListClientSeller vClientSeller;
        private clsListHouse vHouse;

        public clsManager()
        {
            vEmployeeID = vName = vPosition = vPhone = vPin = vCity = vGender = vEmail = vUsername = "Not Defined";
            vBranchID = -1;
            vBirthday = new DateTime();
            vClientBuyer = new clsListClientBuyer();
            vClientSeller = new clsListClientSeller();
            vHouse = new clsListHouse();
        }


        public clsManager(string employeeID, string name, string position, string phone, string pin, string city, DateTime birthday, clsListClientBuyer clientsBuyer, clsListClientSeller clientsSeller, clsListHouse houses)
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

        public clsManager(string employeeID, string name, string position, string phone, string pin, string username ,string city , string email, int branchid)
        {
            vEmployeeID = employeeID;
            vName = name;
            vPosition = position;
            vPhone = phone;
            vPin = pin;
            vCity = city;
            vUsername = username;
            vEmail = email;
            vBranchID = branchid;
            vBirthday = new DateTime();
            vClientBuyer = new clsListClientBuyer();
            vClientSeller = new clsListClientSeller();
            vHouse = new clsListHouse();
        }

        public string EmployeeID
        {
            get => vEmployeeID;
            set
            {
                vEmployeeID = value;
            }
        }

        public string Username
        {
            get => vUsername;
            set
            {
                vUsername = value;
            }
        }

        public string Email
        {
            get => vEmail;
            set
            {
                vEmail = value;
            }
        }

        public int BranchID
        {
            get => vBranchID;
            set
            {
                vBranchID = value;
            }
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
