using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedRockPaperEtc
{
    class GameLogic
    {
        Player playerOne;
        Player playerTwo;
        public void PlayGame()
        {
            PrintIntro();
            GameType();
            Console.Clear();
            BestOfFive();
            PlayAgain();
        }
        public void PrintIntro()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Spock, Lizard.");
            Console.WriteLine("We'll play first to 3, I'll keep track.");
            Console.WriteLine("Please enter the number of players(1 or 2): ");
        }

       public void GameType()
        {    
            int numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 1)
            {
                playerOne = new Human("Player", 0, 0);
                playerTwo = new Computer("Computer", 0, 0);
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human("Player 1", 0, 0);
                playerTwo = new Human("Player 2", 0, 0);
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2: ");
                GameType();
            }    
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? ");
            string playAgain = Console.ReadLine();
            playAgain.ToLower();
            switch (playAgain)
            {
                case "yes":
                    Console.Clear();
                    PlayGame();
                    break;
                case "no":
                    Console.WriteLine("Thanks for playing, goodbye.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("I'm sorry, I didn't get that.");
                    PlayAgain();
                    break;
            }
        }
        public int Winner()
        {
            
            int result;
            result = (5 + playerOne.playerChoice - playerTwo.playerChoice) % 5;
            return result;
        }

        public void DecideWinner()
        {
            int result;
            result = Winner();
            if (result == 0)
            {
                Console.WriteLine("Tie!");

            }
            else if (result % 2 == 1)
            {
                Console.WriteLine(playerOne.name + " Won!");
                playerOne.playerScore++;
            }
            else if (result % 2 == 0)
            {
                Console.WriteLine(playerTwo.name + " Won!");
                playerTwo.playerScore++;
            }
            Console.WriteLine(playerOne.name + ": " + playerOne.playerScore + "  " + playerTwo.name + ": " + playerTwo.playerScore);
        }

        public void BestOfFive()
        {
            while(playerOne.playerScore < 3 && playerTwo.playerScore < 3)
            {
                playerOne.GetPlayerChoice();
                playerTwo.GetPlayerChoice();
                playerOne.ShowChoice();
                playerTwo.ShowChoice();
                DecideWinner();
            }
            if (playerOne.playerScore == 3)
            {
                Console.WriteLine(playerOne.name + " Won!");
            }
            else if (playerTwo.playerScore == 3)
            {
                Console.WriteLine(playerTwo.name + " Won!");
            }
        }
    }
}
