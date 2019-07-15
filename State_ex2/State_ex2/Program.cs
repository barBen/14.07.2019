using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            INewLogin startState = new INewLogin(ctx);
            ctx.Init(startState);

            ctx.newLogin("1");
            ctx.newLogin("1234");
            ctx.newLogin("12345");      
            ctx.newLogin("123");
            ctx.restart();
            ctx.newLogin("12345");
            ctx.newLogin("12345");
            ctx.newLogin("123");
        }
    }
}
