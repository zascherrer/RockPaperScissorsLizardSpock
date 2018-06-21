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
        GestureComparer gestureComparer;
        Player playerOne;
        Player playerTwo;
        bool playerTwoIsHuman;

        //constructor
        public GameSystem(bool playerTwoIsHuman)
        {
            this.playerTwoIsHuman = playerTwoIsHuman;

            gestureComparer = new GestureComparer();
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
            int playerOneWinCounter = 0;
            int playerTwoWinCounter = 0;
            int tieCounter = 0;
            bool playerOneWins = false;
            bool playerTwoWins = false;

            while(!playerOneWins && !playerTwoWins)
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

                int resultOfRound = gestureComparer.DetermineVictor(playerOneChoice, playerTwoChoice);

                if(resultOfRound == 1)
                {
                    Console.WriteLine("Player one wins the round!\n\n");
                    playerOneWinCounter++;
                }
                else if(resultOfRound == -1)
                {
                    Console.WriteLine("Player two wins the round!\n\n");
                    playerTwoWinCounter++;
                }
                else
                {
                    Console.WriteLine("The round was a tie!\n\n");
                    tieCounter++;
                }

                if(playerOneWinCounter >= 2)
                {
                    Console.WriteLine("Player one wins the game!!");
                    playerOneWins = true;
                }

                if(playerTwoWinCounter >= 2)
                {
                    Console.WriteLine("Player two wins the game!!");
                    playerTwoWins = true;
                }
            }
            Console.ReadLine();         //Just here to pause the console so the player can read
        }
    }
}
