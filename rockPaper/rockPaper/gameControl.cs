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
        public Player player1;
        public Player player2;
        public int Player1Win;
        public int Player2Win;

        //constructor
        public game()
        {
            DisplayRuleSet();
            AskForPlayerCount();
            
        }
        //member methods
        public string PromptFor(string str)
        {
            Console.WriteLine(str);
            string input = Console.ReadLine();
            return input;
        }
        public void AskForPlayerCount()
        {

            switch (PromptFor("How many players?"))
            {

                case "0":
                    player1 = new Computer();
                    player2 = new Computer();
                    PlayGame(); 
                    break;
                
                case "1":
                    player1 = new Human();
                    player2 = new Computer();
                    PlayGame();
                    break;

                case "2":
                   player1 = new Human();
                   player2 = new Human();
                    PlayGame();
                    break; 

                default:
                    break;

            }
        }
        public void PlayGame()
        {
            do
            {
                gesture results = player1.ChooseGesture();
                gesture results2 = player2.ChooseGesture();
                if (results.IDList[1] == results2.IDList[1])
                {
                    Console.WriteLine("tie");

                }
                else if (results.IDList[0] == results2.IDList[1] || results.IDList[0] == results2.IDList[2])
                {
                    Console.WriteLine("Player 1 used" + results);
                    Console.WriteLine("Player 2 used" + results2);
                    Console.WriteLine("player 1 won");
                    

                    Player1Win++;
                }
                else if (results2.IDList[0] == results.IDList[1] || results2.IDList[0] == results.IDList[2])
                {
                    Console.WriteLine("Player 1 used" + results.IDList[0]);
                    Console.WriteLine("Player 2 used" + results2.IDList[0]);
                    Console.WriteLine("player 2 won");
                    Player2Win++;
                }
                if(Player1Win == 3)
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("player 1 wins");
                    break;
                }
                if (Player2Win == 3)
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("player 2 wins");
                    break; 
                }

            } while (Player1Win< 2||Player2Win<2);
            

        }

       
        public void DisplayRuleSet()
        {
         
         
          switch (PromptFor("do you want too see the rules,(yes)(no)"))
            {
                case "yes":
                    Console.WriteLine("(Rock crushes Scissors) (Scissors cuts PaperPaper) (covers RockRock crushes)");
                    Console.WriteLine(" (LizardLizard poisons Spock) (Spock smashes Scissors) (Scissors decapitates Lizard)");
                    Console.WriteLine("(Lizard eats Paper) (Paper disproves Spock) (Spock vaporizes Rock)");
                    Console.ReadLine();
                break;
               
                case "no":
                   
                    break;
                
                default:
                    break;

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
