using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            LogLevelHandlerBase loglevelFATAL = new LogLevelFatal();
            LogLevelHandlerBase loglevelERROR = new LogLevelError();
            LogLevelHandlerBase loglevelINFO = new LogLevelInfo();
            LogLevelHandlerBase loglevelDEBUG = new LogLevelDebug();

            LogLevelHandlerBase chainRoot = loglevelFATAL;
            loglevelFATAL.SetNext(loglevelERROR);
            loglevelERROR.SetNext(loglevelINFO);
            loglevelINFO.SetNext(loglevelDEBUG);

            chainRoot.Log(4, "Debug");
            Console.WriteLine("==================");
            chainRoot.Log(2, "Error");
            Console.WriteLine("==================");
            Console.WriteLine("==================");

            LogLevelHandlerBase ReverschainRoot = loglevelDEBUG;
            loglevelDEBUG.SetNext(loglevelINFO);
            loglevelINFO.SetNext(loglevelERROR);
            loglevelERROR.SetNext(loglevelFATAL);

            ReverschainRoot.Log(4, "Debug");
            Console.WriteLine("==================");
            ReverschainRoot.Log(2, "Error");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
        }
    }
}
