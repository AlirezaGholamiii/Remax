using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsListClientSeller
    {
        // private or hidden dictionary to encapsulate our own list
        
        private Dictionary<string, clsClientSeller> myListSeller;

        public clsListClientSeller()
        {
            
            myListSeller = new Dictionary<string, clsClientSeller>();
        }


        public int SellersQuantity
        {
            get { return myListSeller.Count; }
        }

        public Dictionary<string, clsClientSeller>.ValueCollection SellersElement
        {
            get => myListSeller.Values;
        }

        public bool AddBuyer(clsClientSeller Seller)
        {
            if (ExistSeller(Seller.ClientID) == false)
            {
                myListSeller.Add(Seller.ClientID, Seller);
                return true;
            }
            else { return false; }

        }


        public bool DeleteSeller(string ClientID)
        {
            return myListSeller.Remove(ClientID);
        }

        public clsClientSeller FindSeller(string ClientID)
        {
            if (ExistSeller(ClientID) == true)
            {
                return myListSeller[ClientID];
            }
            else { return null; }
        }

        public bool ExistSeller(string ClientID)
        {
            return myListSeller.ContainsKey(ClientID);
        }



        public string DisplaySellers()
        {
            string info = "";
            foreach (clsClientSeller itm in myListSeller.Values)
            {
                info += itm.Display() + "\n";
            }
            return info;
        }
    }
}
