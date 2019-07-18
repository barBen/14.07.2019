using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Game
    {
        public SpaceshipState State { get; set; }

        public Game()
        {
            this.State = new NewGameState(this);
        }

        public void GetHit()
        {
            this.State.GetHit();
        }

        public void NextLevel()
        {
            this.State.NextLevel();
        }
    }
}
