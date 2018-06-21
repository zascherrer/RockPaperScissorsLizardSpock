using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class HumanPlayer : Player
    {
        //variables

        //constructor
        public HumanPlayer()
        {

        }

        //methods
        public override Gesture ChooseGesture()
        {
            bool choiceIsValid = false;
            bool userInputIsNumber = false;
            int userInput;
            Gesture chosenGesture = gesturesAvailable[0];         //This is just a default to check for bugs; it should be overwritten

            while (!choiceIsValid)
            {
                Console.WriteLine("Choose the number corresponding to your choice:");
                Console.WriteLine(" 1. Rock");
                Console.WriteLine(" 2. Paper");
                Console.WriteLine(" 3. Scissors");
                Console.WriteLine(" 4. Lizard");
                Console.WriteLine(" 5. Spock \n");

                userInputIsNumber = int.TryParse(Console.ReadLine(), out userInput);

                if (userInputIsNumber)
                {
                    choiceIsValid = ValidateGestureChoice(userInput);
                }

                if (choiceIsValid)
                {
                    switch (userInput)
                    {
                        case 1:
                            chosenGesture = gesturesAvailable[0];
                            break;
                        case 2:
                            chosenGesture = gesturesAvailable[1];
                            break;
                        case 3:
                            chosenGesture = gesturesAvailable[2];
                            break;
                        case 4:
                            chosenGesture = gesturesAvailable[3];
                            break;
                        case 5:
                            chosenGesture = gesturesAvailable[4];
                            break;
                        default:
                            chosenGesture = gesturesAvailable[0];
                            break;
                    }
                }
            }

            return chosenGesture;
        }

        public bool ValidateGestureChoice(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("\n\nYou chose Rock!\n\n");
                    return true;
                case 2:
                    Console.WriteLine("\n\nYou chose Paper!\n\n");
                    return true;
                case 3:
                    Console.WriteLine("\n\nYou chose Scissors!\n\n");
                    return true;
                case 4:
                    Console.WriteLine("\n\nYou chose Lizard!\n\n");
                    return true;
                case 5:
                    Console.WriteLine("\n\nYou chose Spock!\n\n");
                    return true;
                default:
                    Console.WriteLine("\n\nPlease enter a number 1-5.\n\n");
                    return false;
            }
        }
    }
}
