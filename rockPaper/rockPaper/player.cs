using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class player
    {
        List<string> actions;

        public string  Actions()
        {
            actions = new List<string>() { "rock", " paper", "scisors", "lizzard", "spock" };
            Console.WriteLine("what action would you like to take?"){
                string input = Console.ReadLine();
                switch (input)
                {
                    case "rock":
                        return actions[0];
                        

                    case "pper":
                        return actions[1];
                        
                    case "scisors":
                        return actions[2];
                       
                    case "lizzard":
                        return actions[3];
                    case "spock":
                        return actions[4];
                    default:
                        return Actions();
                }
            
            
            //List<string> menu;
            //constructor
        }   
    }
}
