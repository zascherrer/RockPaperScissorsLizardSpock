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
        public List<Gesture> gesturesAvailable;

        //constructor
        public Player()
        {
            name = "Default_Name";
            gesturesAvailable = new List<Gesture>();
            gesturesAvailable.Add(new Rock());
            gesturesAvailable.Add(new Paper());
            gesturesAvailable.Add(new Scissors());
            gesturesAvailable.Add(new Lizard());
            gesturesAvailable.Add(new Spock());
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
