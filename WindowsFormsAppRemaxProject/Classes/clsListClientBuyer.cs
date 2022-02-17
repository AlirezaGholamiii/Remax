using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsListClientBuyer
    {
        // private or hidden dictionary to encapsulate our own list
        private Dictionary<string, clsClientBuyer> myListBuyer;
     

        public clsListClientBuyer()
        {
            myListBuyer = new Dictionary<string, clsClientBuyer>();
          
        }

        public int BuyersQuantity
        {
            get { return myListBuyer.Count; }
        }

        public Dictionary<string, clsClientBuyer>.ValueCollection BuyersElement
        {
            get => myListBuyer.Values;
        }

        public bool AddBuyer(clsClientBuyer Buyer)
        {
            if (ExistBuyer(Buyer.ClientID) == false)
            {
                myListBuyer.Add(Buyer.ClientID, Buyer);
                return true;
            }
            else { return false; }

        }

        public bool DeleteBuyer(string ClientID)
        {
            return myListBuyer.Remove(ClientID);
        }

        public clsClientBuyer FindBuyer(string ClientID)
        {
            if (ExistBuyer(ClientID) == true)
            {
                return myListBuyer[ClientID];
            }
            else { return null; }
        }

        public bool ExistBuyer(string ClientID)
        {
            return myListBuyer.ContainsKey(ClientID);
        }


    }
}
