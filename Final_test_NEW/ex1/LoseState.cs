using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class LoseState : SpaceshipState
    {
        public LoseState(Game game)
        {
            this.Game = game;
        }

        public override void GetHit()
        {
            Console.WriteLine("you already lose");
        }

        public override void NextLevel()
        {
            Console.WriteLine("you already lose");
        }
    }
}
