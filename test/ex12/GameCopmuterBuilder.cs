using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class GameCopmuterBuilder : ComputerBuilder
    {
        protected override void createEnclosure()
        {
            computer.createEnclosure("Game computer -- Enclosure");
        }

        protected override void addMotherboard()
        {
            computer.addMotherboard("Game computer -- Motherboard");
        }

        protected override void addProcessor()
        {
            computer.addProcessor("Game computer -- processor");
        }

        protected override void addGraphicCard()
        {
            computer.addGraphicCard("Game computer -- graphic card");
        }

        protected override void addMemory()
        {
            computer.addMemory("Game computer -- memory");
        }
    }
}
