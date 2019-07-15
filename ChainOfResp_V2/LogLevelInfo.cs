using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_V2
{
    class LogLevelInfo : LogLevelHandlerBase
    {
        private const int InfoLevel = 3;

        public override void Log(int level, string errorMsg)
        {
            if (level == InfoLevel)
            {
                Console.WriteLine($"Info level: {level}, error: {errorMsg}");
            }
            else if (next != null)
            {
                next.Log(level, errorMsg);
            }
            else
                return;
        }
    }
}
