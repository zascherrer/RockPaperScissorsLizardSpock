using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Rock : Gesture
    {
        //variables

        //constructor
        public Rock()
        {
            name = "Rock";
            winsAgainstThese.Add("Scissors");
            winsAgainstThese.Add("Lizard");
        }

        //methods
    }
}
