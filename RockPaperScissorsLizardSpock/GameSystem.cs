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

        //constructor
        public GameSystem(bool playerTwoIsHuman)
        {
            gestureComparer = new GestureComparer();
            playerOne = new HumanPlayer();
            if (playerTwoIsHuman)
            {
                playerTwo = new HumanPlayer();
            }
            else
            {
                //playerTwo is AI
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
                Gesture playerTwoChoice = playerTwo.PlayerTurn();

                int resultOfRound = gestureComparer.DetermineVictor(playerOneChoice, playerTwoChoice);

                if(resultOfRound == 1)
                {
                    Console.WriteLine("Player one wins the round!");
                    playerOneWinCounter++;
                }
                else if(resultOfRound == -1)
                {
                    Console.WriteLine("Player two wins the round!");
                    playerTwoWinCounter++;
                }
                else
                {
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
