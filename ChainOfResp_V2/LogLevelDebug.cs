using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_V2
{
    class LogLevelDebug : LogLevelHandlerBase
    {
        private const int DebugLevel = 4;

        public override void Log(int level, string errorMsg)
        {
            if (level == DebugLevel)
            {
                Console.WriteLine($"Debug level: {level}, error: {errorMsg}");
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
