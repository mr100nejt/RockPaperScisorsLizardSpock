﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class scisors:gesture
    {
        public int ID;
        public int LoseID1;
        public int LoseID2;
        
        public override void EstablishID()
        {
            LoseID1 = 111;
            LoseID2 = 555;
            ID = 333;
            IDList = new List<int>() { ID, LoseID1, LoseID2 };
        }
    }
}
