using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public abstract class SpaceshipState
    {
        protected const int WINLEVEL = 4;
        protected const int DANGER_VAL = 10;
        private const int START_HIT = 50;

        private Game game;

        protected int level;
        protected int hitPoints = START_HIT;

        internal Game Game { get => game; set => game = value; }

        public abstract void NextLevel();
        public abstract void GetHit();
    }
}
