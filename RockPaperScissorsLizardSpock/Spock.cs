using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Spock : Gesture
    {
        //variables

        //constructor
        public Spock()
        {
            name = "Spock";
            winsAgainstThese.Add("Scissors");
            winsAgainstThese.Add("Rock");
        }

        //methods
    }
}
