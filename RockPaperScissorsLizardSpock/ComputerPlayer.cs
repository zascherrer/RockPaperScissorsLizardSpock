using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class ComputerPlayer : Player
    {
        //variables
        Random randomSeed;

        //constructor
        public ComputerPlayer()
        {
            name = "Computer";
            randomSeed = new Random();
        }

        //methods
        public override Gesture ChooseGesture()
        {
            int randomInt = randomSeed.Next(gesturesAvailable.Count);
            Gesture chosenGesture = gesturesAvailable[randomInt];
            ValidateGestureChoice(randomInt + 1);                       // The +1 is needed to make the computer's randomInt line up with 
                                                                        // the human's userInput and allow them to use the same method

            return chosenGesture;
        }
    }
}
