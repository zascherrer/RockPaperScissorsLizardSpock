using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class GameSystem
    {
        //variables
        //GestureComparer gestureComparer;
        Player playerOne;
        Player playerTwo;
        bool playerTwoIsHuman;

        //constructor
        public GameSystem(bool playerTwoIsHuman)
        {
            this.playerTwoIsHuman = playerTwoIsHuman;

            //gestureComparer = new GestureComparer();
            Console.WriteLine("\n\nPlayer One,");
            playerOne = new HumanPlayer();
            if (playerTwoIsHuman)
            {
                Console.WriteLine("\n\nPlayer Two,");
                playerTwo = new HumanPlayer();
            }
            else
            {
                playerTwo = new ComputerPlayer();
            }
        }

        //methods
        public void RunGame()
        {
            while(!playerOne.winsGame && !playerTwo.winsGame)
            {
                Gesture playerOneChoice = playerOne.PlayerTurn();
                if (playerTwoIsHuman)
                {
                    Console.Clear();
                }
                Gesture playerTwoChoice = playerTwo.PlayerTurn();
                if (playerTwoIsHuman)
                {
                    Console.Clear();
                }

                RoundResults(playerOneChoice, playerTwoChoice);
                CheckForVictory();
                
            }
            Console.ReadLine();         //Just here to pause the console so the player can read
        }

        public void RoundResults(Gesture playerOneChoice, Gesture playerTwoChoice)
        {
            int resultOfRound = GestureComparer.DetermineVictor(playerOneChoice, playerTwoChoice);

            if (resultOfRound == 1)
            {
                Console.WriteLine("{0} wins the round!\n\n", playerOne.name);
                playerOne.score++;
            }
            else if (resultOfRound == -1)
            {
                Console.WriteLine("{0} wins the round!\n\n", playerTwo.name);
                playerTwo.score++;
            }
            else
            {
                Console.WriteLine("The round was a tie!\n\n");
            }
        }

        public void CheckForVictory()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine("{0} wins the game!!", playerOne.name);
                playerOne.winsGame = true;
            }

            if (playerTwo.score >= 2)
            {
                Console.WriteLine("{0} wins the game!!", playerTwo.name);
                playerTwo.winsGame = true;
            }
        }
    }
}
