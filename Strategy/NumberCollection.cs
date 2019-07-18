using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NumberCollection
    {
        protected List<int> numbers = new List<int>();
        Isort sorter;
        private const int SORT = 3;

        public NumberCollection(Isort sorter)
        {
            this.sorter = sorter;
        }

        public void add(int toAdd)
        {
            Console.WriteLine($"add {toAdd}");
            this.numbers.Add(toAdd);
            if (this.numbers.Count() >= SORT)
            {
                this.sorter = new QuickSort();
            }
        }

        public void remove(int toRemove)
        {
            Console.WriteLine($"remove {toRemove}");
            this.numbers.Remove(toRemove);
            if (this.numbers.Count() < SORT)
            {
                this.sorter = new MergeSort();
            }
        }

        public void sort()
        {
            this.sorter.Sort(numbers);
        }
    }
}
