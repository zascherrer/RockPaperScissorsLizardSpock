using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Gesture
    {
        //variables
        public string name;
        public List<string> winsAgainstThese;

        //constructor
        public Gesture()
        {
            winsAgainstThese = new List<string>();
        }

        //methods
    }
}
