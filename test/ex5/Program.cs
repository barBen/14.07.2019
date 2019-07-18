using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandlerBase infoHandler = new InfoHandler();
            LogHandlerBase errorHandler = new ErrorHandler();
            LogHandlerBase fatalHandler = new FatalHandler();


            LogHandlerBase chainRoot = infoHandler;
            infoHandler.SetNext(errorHandler);
            errorHandler.SetNext(fatalHandler);

            Console.WriteLine("error log", 2);
            chainRoot.Handle("error log", 2);
            Console.WriteLine();

            Console.WriteLine("fatal log", 1);
            chainRoot.Handle("fatal log", 1);
            Console.WriteLine();

            Console.WriteLine("info log", 3);
            chainRoot.Handle("info log", 3);
        }
    }
}
