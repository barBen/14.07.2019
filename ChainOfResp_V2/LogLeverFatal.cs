using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_V2
{
    class LogLevelFatal : LogLevelHandlerBase
    {
        private const int FatalLevel = 1; 

        public override void Log(int level, string errorMsg)
        {
            if (level == FatalLevel)
            {
                Console.WriteLine($"fatal error level: {level}, error: {errorMsg}");
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
