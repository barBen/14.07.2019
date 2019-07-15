using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace prototype_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            string url2 = "http://www.google.com";

            WebInfoFactory webFactory = new WebInfoFactory();

            Console.WriteLine(webFactory.CreateWebInfo(url));
            Console.WriteLine(webFactory.CreateWebInfo(url2));
            Console.WriteLine(webFactory.CreateWebInfo(url));
        }
    }
}
