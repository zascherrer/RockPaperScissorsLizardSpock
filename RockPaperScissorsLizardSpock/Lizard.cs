using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Lizard : Gesture
    {
        //variables

        //constructor
        public Lizard()
        {
            name = "Lizard";
            winsAgainstThese.Add("Spock");
            winsAgainstThese.Add("Paper");
        }

        //methods
    }
}
