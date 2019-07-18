using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public abstract class LogHandlerBase
    {
        protected LogHandlerBase next;

        public abstract void Handle(string log, int level);

        public void SetNext(LogHandlerBase next)
        {
            this.next = next;
        }
    }
}
