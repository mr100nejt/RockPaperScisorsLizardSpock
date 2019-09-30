using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class Computer:Player
    {
        public gesture Rock = new rock();
        public gesture Paper = new paper();
        public gesture Scisors = new scisors();
        public gesture Lizzard = new lizzard();
        public gesture Spock = new spock();
        public List<gesture> actions;
        private Random randomNumber; 
        public Computer()
        {
            MakeListOfGestures();
            randomNumber = new Random(); 
        }
        public List<gesture> MakeListOfGestures()
        {
            actions = new List<gesture>() { Rock, Paper, Scisors, Lizzard, Spock };
            return actions;
        }
       
        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(actions.Count - 1);
        }
        public override gesture ChooseGesture()
        {

            
            System.Threading.Thread.Sleep(1000);
            return actions[RandomNumber()];
        }


    }
}
