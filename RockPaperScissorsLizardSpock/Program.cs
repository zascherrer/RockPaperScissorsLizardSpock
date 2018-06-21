using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            GameModeSelector mode = new GameModeSelector();
            bool willPlayAgainstFriend = mode.SelectMode();

            GameSystem game = new GameSystem(willPlayAgainstFriend);

            game.RunGame();
        }
    }
}
