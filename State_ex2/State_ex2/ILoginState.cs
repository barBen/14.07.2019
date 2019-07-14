using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_ex2
{
    public interface ILoginState
    {
        void Login(string password);
        void Restart();

    }
}
