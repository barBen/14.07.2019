using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
    public abstract class LoginBase : ILoginState
    {

        protected const string Pass = "123";
        protected Context ctx;

        protected LoginBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);
        public abstract void Restart();
    }
}
