using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class WinState : SpaceshipState
    {
        public WinState(Game game)
        {
            this.Game = game;
        }
        public override void GetHit()
        {
            Console.WriteLine("you already win");
        }

        public override void NextLevel()
        {
            Console.WriteLine("you already win");
        }
    }
}
