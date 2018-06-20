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
        public override void ChooseGesture()
        {
            bool choiceIsValid = false;

            while (!choiceIsValid)
            {
                Console.WriteLine("Choose the number corresponding to your choice:");
                Console.WriteLine(" 1. Rock");
                Console.WriteLine(" 2. Paper");
                Console.WriteLine(" 3. Scissors");
                Console.WriteLine(" 4. Lizard");
                Console.WriteLine(" 5. Spock \n");

                string userInput = Console.ReadLine();
                choiceIsValid = ValidateGestureChoice(userInput);
            }

        }

        public bool ValidateGestureChoice(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("\n\nYou chose Rock!\n\n");
                    return true;
                case "2":
                    Console.WriteLine("\n\nYou chose Paper!\n\n");
                    return true;
                case "3":
                    Console.WriteLine("\n\nYou chose Scissors!\n\n");
                    return true;
                case "4":
                    Console.WriteLine("\n\nYou chose Lizard!\n\n");
                    return true;
                case "5":
                    Console.WriteLine("\n\nYou chose Spock!\n\n");
                    return true;
                default:
                    Console.WriteLine("\n\nPlease enter a number 1-5.\n\n");
                    return false;
            }
        }
    }
}
