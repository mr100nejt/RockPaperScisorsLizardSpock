using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class scisors:gesture
    {
        public string ID;
        public string LoseID1;
        public string LoseID2;
        
        public override void EstablishID()
        {
            LoseID1 = " Rock";
            LoseID2 = " Spock";
            ID = " Scissors";
            IDList = new List<string>() { ID, LoseID1, LoseID2 };
        }
    }
}
