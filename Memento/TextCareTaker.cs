using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        private int index = -1;
        List<TextMemento> momentoList = new List<TextMemento>();

        public void AddMemento(TextMemento memento)
        {
            this.momentoList.Add(memento);
            index++;
            //this.momentoList = this.momentoList.GetRange(0, index);
            this.momentoList.RemoveRange(index, momentoList.Count-index-1);
        }

        public TextMemento GetPrev()
        {
            if (index > 0) 
            {
                index--;
                return this.momentoList[index];
            }

            else if (index == 0 )
            {
                return this.momentoList[index];
            }

            return null;
        }

        public TextMemento GetNext()
        {
            if (index < this.momentoList.Count & index != -1)
            {
                index++;
                return this.momentoList[index-1];
            }

            return null;
        }
    }
}
