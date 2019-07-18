using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class OKState : SpaceshipState
    {
        public OKState(Game game)
        {
            this.Game = game;
        }
        public override void GetHit()
        {
            hitPoints--;
            if (hitPoints < DANGER_VAL)
            {
                Game.State = new DangerState(Game);
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
