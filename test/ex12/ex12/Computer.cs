using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public class Computer
    {
        private List<String> component = new List<String>();

        public Computer()
        {
            // createEnclosure
            // addMotherboard
            // addProcessor
            // addGraphicCard
            // addMemory
            // runCheck
        }

        public void createEnclosure(string Enclosure)
        {
            component.Add(Enclosure);
        }

        public void addMotherboard(string motherboard)
        {
            component.Add(motherboard);
        }

        public void addProcessor(string processor)
        {
            component.Add(processor);
        }

        public void addGraphicCard(string graphicCard)
        {
            component.Add(graphicCard);
        }

        public void addMemory(string memory)
        {
            component.Add(memory);
        }

        public override string ToString()
        {
            return $"component: \n  Enclosure: {component[0]} \n  Motherboard: {component[1]} \n  Processor: {component[2]} \n  GraphicCard: {component[3]} \n  Memory: {component[4]} \n";
        }
    }
}
