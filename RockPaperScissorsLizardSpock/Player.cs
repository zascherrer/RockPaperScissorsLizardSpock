using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        //variables
        public string name;

        //constructor
        public Player()
        {
            name = "Default_Name";
        }

        //methods
        public virtual Gesture ChooseGesture()
        {
            return new Rock();
        }

        public Gesture PlayerTurn()
        {
            Console.WriteLine("It's {0}'s turn to choose! \n\n", name);
            Gesture chosenGesture = ChooseGesture();
            return chosenGesture;
        }

    }
}
