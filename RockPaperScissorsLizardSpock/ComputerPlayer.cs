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

            return chosenGesture;
        }
    }
}
