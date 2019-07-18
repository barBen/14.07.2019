using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class LivingRoomComputerBuilder : ComputerBuilder
    {
        protected override void createEnclosure()
        {
            computer.createEnclosure("LivingRoom computer -- Enclosure");
        }

        protected override void addMotherboard()
        {
            computer.addMotherboard("LivingRoom computer -- Motherboard");
        }

        protected override void addProcessor()
        {
            computer.addProcessor("LivingRoom computer -- processor");
        }

        protected override void addGraphicCard()
        {
            computer.addGraphicCard("LivingRoom computer -- graphic card");
        }

        protected override void addMemory()
        {
            computer.addMemory("LivingRoom computer -- memory");
        }
    }
}
