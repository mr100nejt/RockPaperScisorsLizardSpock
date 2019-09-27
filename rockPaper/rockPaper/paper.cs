using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class paper : gesture
    {
        public int ID;
        public int LoseID1;
        public int LoseID2;
      

        public override void EstablishID()
        {
            LoseID1 = 333;
            LoseID2 = 444;
            ID = 222;
             IDList = new List<int>() { ID, LoseID1, LoseID2 };
        }
    }
}
