using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame_v2.UI  // namespace
{
    class Program  // class
    {
        static void Main(string[] args)  // method
        {
            GameFlow game = new GameFlow();
            game.PlayGame();
        }
    }
}
