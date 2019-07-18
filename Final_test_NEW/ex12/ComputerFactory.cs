using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class ComputerFactory
    {
        public Computer createComputer(string newComputer)
        {
            switch (newComputer)
            {
                case ("game"):
                    {
                        GameCopmuterBuilder gameComp = new GameCopmuterBuilder();
                        gameComp.BuildComputer();
                        return gameComp.GetComputer();
                    }
                case ("work"):
                    {
                        WorkComputerBuilder workComputer = new WorkComputerBuilder();
                        workComputer.BuildComputer();
                        return workComputer.GetComputer();
                    }
                case ("living room"):
                    {
                        LivingRoomComputerBuilder livingRoomComputer = new LivingRoomComputerBuilder();
                        livingRoomComputer.BuildComputer();
                        return livingRoomComputer.GetComputer();
                    }
                default:
                    throw new Exception("computer doent exsit.");
            }
        }
    }
}
