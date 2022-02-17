using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsClientBuyer
    {

        private string vClientID;
        private string vName;
        private string vTitle;
        private string vPhone;
        private string vcountry;
        private string vEmail;
        private clsListHouse vHouse;

        public clsClientBuyer()
        {
            vClientID = vName = vTitle = vPhone = vcountry = vEmail = "Not Defined";
            vHouse = new clsListHouse();
        }


        public clsClientBuyer(string clientID, string name, string title, string phone, string country, string email, clsListHouse houses)
        {
            vClientID = clientID;
            vName = name;
            vTitle = title;
            vPhone = phone;
            vcountry = country;
            vEmail = email;
            vHouse = houses;
        }

        public clsClientBuyer(string clientID, string name, string title, string phone, string country, string email)
        {
            vClientID = clientID;
            vName = name;
            vTitle = title;
            vPhone = phone;
            vcountry = country;
            vEmail = email;
            vHouse = new clsListHouse();
        }

        public string ClientID
        {
            get => vClientID;
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string Title
        {
            get => vTitle;
            set
            {
                vTitle = value;
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

        public string Country
        {
            get => vcountry;
            set
            {
                vcountry = value;
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

        public clsListHouse Houses
        {
            get => vHouse;
            set
            {
                vHouse = value;
            }
        }

        public void Register(string clientID, string name, string title, string phone, string country, string email)
        {
            vClientID = clientID;
            vName = name;
            vTitle = title;
            vPhone = phone;
            vcountry = country;
            vEmail = email;

        }
        //for test
        public string Display()
        {
            string info = "\n---- Client------\nClient ID: " + vClientID + "\nName: " + vName + "\nTitle: " + vTitle + "\nPhone: " + vPhone + "\nCountry: " + vcountry
                 + "\nEmail: " + vEmail + "\n\n   Houses---\n"
                 + vHouse.Display() + "\n";
            return info;
        }
    }
}
