using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class spock : gesture
    {

        public string ID;
        public string LoseID1;
        public string LoseID2;

        public override void EstablishID()
        {
            LoseID1 = " Paper";
            LoseID2 = " Lizzard";
            ID = " Spock";
             IDList = new List<string>() { ID, LoseID1, LoseID2 };
        }
    }
}
