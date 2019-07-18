using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberCollection collection = new NumberCollection();

            collection.add(1);
            collection.sort();
            collection.add(2);
            collection.sort();
            collection.add(3);
            collection.sort();
            collection.add(4);
            collection.sort();
            collection.add(5);
            collection.sort();
            collection.remove(5);
            collection.sort();
            collection.remove(4);
            collection.sort();
            collection.remove(2);
            collection.sort();
        }
    }
}
