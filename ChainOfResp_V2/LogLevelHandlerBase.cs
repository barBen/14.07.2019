using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_V2
{
    public abstract class LogLevelHandlerBase
    {
        protected LogLevelHandlerBase next;

        public abstract void Log(int level, string errorMsg);

        public void SetNext(LogLevelHandlerBase next)
        {
            this.next = next;
        }
    }
}
