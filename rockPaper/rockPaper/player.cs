using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    abstract class Player
    {
        public List<gesture> MakeListOfGestures; 
        public gesture gesture;
       
        public  Player()
        {
            
           
            

        }
       

            public abstract gesture ChooseGesture();


       
    }
}
