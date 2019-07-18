using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class DangerState : SpaceshipState
    {
        public DangerState(Game game)
        {
            this.Game = game;
        }

        public override void GetHit()
        {
            hitPoints--;
            if (hitPoints == 0)
            {
                Game.State = new LoseState(Game);
            }
            Console.WriteLine($"get hit. hitPoint: {hitPoints}");
        }

        public override void NextLevel()
        {
            level++;
            if (level == WINLEVEL)
            {
                Game.State = new WinState(Game);
            }
            Console.WriteLine($"get to the next level. LEVEL: {level}");
        }
    }
}
