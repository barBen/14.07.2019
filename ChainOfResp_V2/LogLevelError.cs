using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_V2
{
    class LogLevelError : LogLevelHandlerBase
    {
        private const int ErrorLevel = 2;

        public override void Log(int level, string errorMsg)
        {
            if (level == ErrorLevel)
            {
                Console.WriteLine($"Error level: {level}, error: {errorMsg}");
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
