using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
    public class ILoginFailed : LoginBase
    {
        private int conter = 3; 

        public ILoginFailed(Context ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            conter--;

            if (password.Equals(Pass))
            {
                Console.WriteLine("Success");
                ctx.State = new ILoginSuccess(ctx);
            }
            else if (conter > 0)
            {
                Console.WriteLine($"FAIL - with pass {password}");
            }
            else
            {
                Console.WriteLine("Locked");
                ctx.State = new ILocked(ctx);
            }
        }

        public override void Restart()
        {
            Console.WriteLine("FAILED - try restart");
            ctx.State = new INewLogin(ctx);
        }
    }
}