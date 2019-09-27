using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class Human : Player
    {
        public gesture Rock = new rock();
        public gesture Paper = new paper();
        public gesture Scisors = new scisors();
        public gesture Lizzard = new lizzard();
        public gesture Spock = new spock();
        public Human()
        {
            
        }
        public override gesture ChooseGesture()
        {
            Console.WriteLine("what gesture would you like to use?");

            string input = Console.ReadLine();
            switch (input)
            {
                case "rock":
                    
                    return Rock;

                case "paper":

                    return Paper;

                case "scissors":
                    return Scisors;

                case "lizard":
                    return Lizzard;

                case "spock":
                    return Spock;

                default:
                    return ChooseGesture();
            }
        }
    }
}
