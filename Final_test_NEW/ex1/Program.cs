using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.NextLevel();
            game.NextLevel();
            game.NextLevel();
            game.GetHit();
            game.GetHit();
            game.GetHit();
        }
    }
}
