﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("Canvas root");
            //Component circle1 = new Leaf("Circle 1");
            //Component rectangle = new Leaf("Rectangle x");
            //root.AddChild(circle1);
            //root.AddChild(rectangle);
            //
            //Component container1 = new Composite("Container 1");
            //Component circle2 = new Leaf("Circle 1");
            //Component circle3 = new Leaf("Circle 2");
            //container1.AddChild(circle2);
            //container1.AddChild(circle3);
            //
            //root.AddChild(container1);
            //
            //Component container2 = new Composite("Container of triangles");
            //Component t1 = new Leaf("Triangle 1");
            //Component t2 = new Leaf("Triangle 2");
            //container2.AddChild(t1);
            //container2.AddChild(t2);
            //
            //root.AddChild(container2);
            //
            Draw(root, "");
            Console.WriteLine(IsBinary(root));
        }

        static void Draw(Component c, string space)
        {
            c.Draw(space);

            if (c.GetChilds() == null)
                return;

            foreach(Component child in c.GetChilds())
            {
                Draw(child, space + "    ");
            }
        }

        static bool IsBinary(Component c)
        {
            if (!c.IsBinary())
                return false;

            if (c.GetChilds() == null)
                return true;

            return (IsBinary(c.GetChilds().Last()) && IsBinary(c.GetChilds().First()));
        }
    }
}
