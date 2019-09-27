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
        public Computer()
        {
            MakeListOfGestures();
        }
        public List<gesture> MakeListOfGestures()
        {
            actions = new List<gesture>() { Rock, Paper, Scisors, Lizzard, Spock };
            return actions;
        }
        public int RandomChoice()
        {
          return  RandomNumber(0, 5);
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public override gesture ChooseGesture()
        {
            return actions[RandomChoice()];
        }


    }
}
