using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class rock : gesture
    {
        public int ID; 
        public int LoseID1;
        public int LoseID2;
       
      public rock()
        {
            EstablishID();
            IDList = new List<int>() { ID, LoseID1, LoseID2 };
        }
            public override void EstablishID()
        {
            LoseID1 = 222;
            LoseID2 = 555;
            ID = 111;
             
        }
    }
}
