using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedRockPaperEtc
{
    public class Computer : Player
    {
        public Computer(string name, int playerScore, int playerChoice)
            :base(name, playerScore, playerChoice)   
        {
            this.name = "Computer";
            this.playerScore = playerScore;

        }

        public override void GetPlayerChoice()
        {
            Random rnd = new Random();
            this.playerChoice = rnd.Next(5);
            switch (this.playerChoice)
            {
                case 0:
                    this.playerChoice = 0;
                    break;

                case 1:
                    this.playerChoice = 1;
                    break;
                case 2:
                    this.playerChoice = 2;
                    break;
                case 3:
                    this.playerChoice = 3;
                    break;
                case 4:
                    this.playerChoice = 4;
                    break;
                default:
                    Console.WriteLine("Enter a valid option.");
                    GetPlayerChoice();
                    break;
            }
            
        }
    }
}
