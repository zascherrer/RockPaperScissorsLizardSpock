using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Paper : Gesture
    {
        //variables

        //constructor
        public Paper()
        {
            name = "Paper";
            winsAgainstThese.Add("Rock");
            winsAgainstThese.Add("Spock");
        }

        //methods
    }
}
