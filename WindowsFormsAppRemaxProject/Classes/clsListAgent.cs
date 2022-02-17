using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppRemaxProject
{
    class clsListAgent
    {
        // private or hidden dictionary to encapsulate our own list
        
        private Dictionary<string, clsAgent> myListAgent;

        public clsListAgent()
        {
           
            myListAgent = new Dictionary<string, clsAgent>();

        }


        public int AgentQuantity
        {
            get { return myListAgent.Count; }
        }


        public Dictionary<string, clsAgent>.ValueCollection AgentElements
        {
            get => myListAgent.Values;
        }


        public bool Add(clsAgent Agent)
        {
            if (ExistAgent(Agent.EmployeeID) == false)
            {
                myListAgent.Add(Agent.EmployeeID, Agent);
                return true;
            }
            else { return false; }

        }

        public bool DeleteAgent(string employeeID)
        {
            return myListAgent.Remove(employeeID);
        }


        public clsAgent FindAgent(string employeeID)
        {
            if (ExistAgent(employeeID) == true)
            {
                return myListAgent[employeeID];
            }
            else { return null; }
        }

        public bool ExistAgent(string employeeID)
        {
            return myListAgent.ContainsKey(employeeID);
        }
    }
}
