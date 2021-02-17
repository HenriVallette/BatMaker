using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatMaker
{
    public class TaskData
    {

        private String logiciel;
        private List<String> commandes;

        public String Logiciel
        {
            get { return this.logiciel; }
            set { this.logiciel = value; }
        }

        public List<String> Commmandes
        {
            get { return this.commandes; }
            set { this.commandes = value; }
        }

        public TaskData(int ID)
        {
            Commmandes = new List<String>();
        }
    }
}
