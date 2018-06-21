using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class GameModeSelector
    {
        //variables

        //constructor
        public GameModeSelector()
        {

        }

        //methods
        public bool SelectMode()
        {
            bool validInput = false;
            bool willPlayAgainstFriend = false;             //Should be overwritten
            int userInput;

            while (!validInput)
            {
                Console.WriteLine("Would you like to play against a computer or against a friend? Enter the number corresponding to your choice:");
                Console.WriteLine(" 1. Computer");
                Console.WriteLine(" 2. Friend");

                validInput = int.TryParse(Console.ReadLine(), out userInput);

                if (validInput)
                {
                    if (userInput < 1 || userInput > 2)
                    {
                        validInput = false;
                    }
                    else
                    {
                        if(userInput == 1)
                        {
                            willPlayAgainstFriend = false;
                        }
                        else
                        {
                            willPlayAgainstFriend = true;
                        }
                    }
                }

                if (!validInput)
                {
                    Console.WriteLine("\n\nPlease enter either 1 or 2.\n\n");
                }
            }

            return willPlayAgainstFriend;
        }
    }
}
