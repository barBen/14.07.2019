using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
        public class INewLogin : LoginBase
        {
            public INewLogin(Context ctx) : base(ctx)
            {
            }

            public override void Login(string password)
            {
                if (password.Equals(Pass))
                {
                    Console.WriteLine("Success");
                    ctx.State = new ILoginSuccess(ctx);
                    }
                else
                {
                    ctx.State = new ILoginFailed(ctx);
                }
            }
       
            public override void Restart()
            {
                Console.WriteLine("you are not login yet");
            }
        }
}
