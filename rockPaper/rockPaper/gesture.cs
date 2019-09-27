using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    abstract class gesture
    {
        public List<int> IDList;
            public gesture()
            {
            EstablishID();
                 
            }
        
      
         public abstract void EstablishID();
    }
}
