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
            Console.WriteLine("LOCKED - you are already locked..");
        }

        public override void Restart()
        {
            Console.WriteLine("LOCKED - try restart");
            ctx.State = new INewLogin(ctx);
        }
    }
}