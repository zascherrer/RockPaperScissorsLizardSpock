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
            bool playerOneWins = false;
            bool playerTwoWins = false;

            while(!playerOneWins && !playerTwoWins)
            {
                playerOne.PlayerTurn();
                playerTwo.PlayerTurn();
            }

        }
    }
}
