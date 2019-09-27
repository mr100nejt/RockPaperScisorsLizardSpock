using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class rock : gesture
    {
        public string ID;
        public string LoseID1;
        public string LoseID2;

        public rock()
        {
            EstablishID();
            IDList = new List<string>() { ID, LoseID1, LoseID2 };
        }
            public override void EstablishID()
        {
            LoseID1 = " Paper";
            LoseID2 = " Spock";
            ID = " Rock";
             
        }
    }
}
