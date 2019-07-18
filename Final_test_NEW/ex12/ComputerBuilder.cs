using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer GetComputer()
        {
            if (computer == null)
                throw new Exception("Computer is not prepared yet!");

            return computer;
        }

        public void BuildComputer()
        {
            this.computer = new Computer();
            createEnclosure();
            addMotherboard();
            addProcessor();
            addGraphicCard();
            addMemory();
        }

        protected abstract void createEnclosure();

        protected abstract void addMotherboard();

        protected abstract void addProcessor();

        protected abstract void addGraphicCard();

        protected abstract void addMemory();
    }
}
