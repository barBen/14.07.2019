using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
    public class ILocked : LoginBase
    {
        public ILocked(Context ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            Console.WriteLine("you are LOCKED");
        }

        public override void Restart()
        {
            Console.WriteLine("LOCKED - restart");
            ctx.State = new INewLogin(ctx);
        }
    }
}