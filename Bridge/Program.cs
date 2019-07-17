using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(2);
            Memir memir = new Memir(5);

            RemoteControle remoteTV = new RemoteControle(tv);
            remoteTV.printStaus();
            remoteTV.off();
            remoteTV.on();
            remoteTV.prev();
            remoteTV.next();
            remoteTV.next();
            remoteTV.next();
            remoteTV.printStaus();
            Console.WriteLine();

            RemoteControle remoteMemir = new RemoteControle(memir);
            remoteMemir.printStaus();
            remoteMemir.off();
            remoteMemir.on();
            remoteMemir.prev();
            remoteMemir.next();
            remoteMemir.off();
            remoteMemir.next();
            remoteMemir.printStaus();
        }
    }
}
