using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class GestureComparer
    {
        //variable

        //constructor
        public GestureComparer()
        {

        }

        //methods
        public int DetermineVictor(Gesture gestureOne, Gesture gestureTwo)
        {
            int playerOneScore;              //This will be set to 1 if player one wins, -1 if player one loses and 0 if there's a tie.

            if(gestureOne.name == gestureTwo.name)
            {
                playerOneScore = 0;
            }
            else if(gestureOne.winsAgainstThese[0] == gestureTwo.name || gestureOne.winsAgainstThese[1] == gestureTwo.name)
            {
                playerOneScore = 1;
            }
            else
            {
                playerOneScore = -1;
            }

            return playerOneScore;
        }
    }
}
