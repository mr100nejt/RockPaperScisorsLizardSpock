using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaper
{
    class game

    {
        //member variables 
        public bool multiplayer;
        public string DisplayRuleSet;
        public player player1;
        public player player2;
        public player BOT; 


        //constructor
        public game()
        {
            player1 = new player();
            player2 = new player();
            BOT = new player(); 
        }
        //member methods
       public string PromptFor(string str)
        {
           Console.WriteLine(str);
            string input = Console.ReadLine();
            return input;
        }
        public bool  AskForPlayerCount()
        {
           

            switch (PromptFor("How many players?"))
            {
                case "1":
                    multiplayer = false;
                    return multiplayer;
                    

                case "2":
                    multiplayer = true;
                    return multiplayer;
                    
                default:
                    return AskForPlayerCount(); 
            
            }
        }
        public void SinglePlayer()
        {
            if(multiplayer == false)
            {

                player1 = new player();
                BOT = new player();
            }
        }
        // establish wether they want to play BOT or player
        // ask if they need to see rules 
        //start game 
        // hold the list of avalible throws 
        //keep up with and compare throws  
        //keep up with wins 
        //if win limit is reached end game 
        //declare winner 
        //display wins for both players?
    
    }
}
