using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class NewGameState : SpaceshipState
    {
        public NewGameState(Game game)
        {
            this.Game = game;
            level = 0;
            Console.WriteLine($"Start new game. LEVEL: {level}. start hit points: {hitPoints}");
            this.NextLevel();
        }

        public override void GetHit()
        {
            Console.WriteLine("you just start the game.");
        }

        public override void NextLevel()
        {
            level++;
            this.Game.State = new OKState(Game);
            Console.WriteLine($"get to the next level. LEVEL: {level}");
        }
    }
}
