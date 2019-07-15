using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
        public class ILoginSuccess : LoginBase
        {
            public ILoginSuccess(Context ctx) : base(ctx)
            {
            }

            public override void Login(string password)
            {
                Console.WriteLine("SUCCESS -you are already login");
            }

            public override void Restart()
            {
                Console.WriteLine("restart");
                ctx.State = new INewLogin(ctx);
            }
        }
}
