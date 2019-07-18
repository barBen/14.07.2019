using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class FatalHandler : LogHandlerBase
    {
        private const int LEVEL = 1;
        public override void Handle(string log, int level)
        {
            if (level == LEVEL)
            {
                Console.WriteLine("FATAL: " + log);
                WriteToFile(log);
            }
            else if (next != null)
            {
                next.Handle(log, level);
            }
        }

        private void WriteToFile(string log)
        {
            Console.WriteLine("Writing fatal to file...");
            File.AppendAllText(@"C:\Users\HackerU\source\repos\test\ex5\ex5\log.txt", Environment.NewLine + "FATAL: " + log);
        }
    }
}
