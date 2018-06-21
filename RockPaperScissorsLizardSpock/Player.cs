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

        public bool ValidateGestureChoice(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("\n\n{0} chose Rock!\n\n", name);
                    return true;
                case 2:
                    Console.WriteLine("\n\n{0} chose Paper!\n\n", name);
                    return true;
                case 3:
                    Console.WriteLine("\n\n{0} chose Scissors!\n\n", name);
                    return true;
                case 4:
                    Console.WriteLine("\n\n{0} chose Lizard!\n\n", name);
                    return true;
                case 5:
                    Console.WriteLine("\n\n{0} chose Spock!\n\n", name);
                    return true;
                default:
                    Console.WriteLine("\n\nPlease enter a number 1-5.\n\n");
                    return false;
            }
        }
    }
}
