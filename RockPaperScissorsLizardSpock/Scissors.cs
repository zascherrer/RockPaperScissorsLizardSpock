using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Scissors : Gesture
    {
        //variables

        //constructor
        public Scissors()
        {
            name = "Scissors";
            winsAgainstThese.Add("Paper");
            winsAgainstThese.Add("Lizard");
        }

        //methods
    }
}
