using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedRockPaperEtc
{
    public class Player
    {
        public string name;
        public int playerChoice = 0;
        public int playerScore = 0;

        public Player(string name, int playerScore, int playerChoice)
        {
            this.name = name;
            this.playerScore = playerScore;
        }
        
        public virtual void GetPlayerChoice()
        {
            Console.WriteLine(this.name + " 1 for rock, 2 for paper, 3 for scissors, 4 for spock, 5 for lizard: ");
            playerChoice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (playerChoice)
            {
                case 1:
                    this.playerChoice = 0;
                    break;
                case 2:
                    this.playerChoice = 1;
                    break;
                case 3:
                    this.playerChoice = 2;
                    break;
                case 4:
                    this.playerChoice = 3;
                    break;
                case 5:
                    this.playerChoice = 4;
                    break;
                default:
                    Console.WriteLine("Enter a valid option.");
                    GetPlayerChoice();
                    break;
            }            
        }

        public virtual void ShowChoice()
        {
            string[] choices = new string[] { "rock", "paper", "scissors", "spock", "lizard" };
            Console.WriteLine(name + " chose " + choices[playerChoice]);
        }
    }
}
