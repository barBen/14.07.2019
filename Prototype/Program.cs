using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(5, 5), 50.5);

            Console.WriteLine(c);

            DoStuffWithCircle((Circle)c.Clone());

            Console.WriteLine(c);

            Rectangle r = new Rectangle(new Point(5, 5), new Point(10, 5), new Point(5, 10), new Point(10, 10));

            Console.WriteLine(r);

            DoStuffWithRectangle((Rectangle)r.Clone());

            Console.WriteLine(r);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ShapeHolder s1 = new ShapeHolder();
            s1.AddShape(c);
            s1.AddShape(r);

            Console.WriteLine(s1);
            
            DoStuffWithList((ShapeHolder)s1.Clone(), c);
            
            Console.WriteLine(s1);
        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }

        public static void DoStuffWithRectangle(Rectangle r)
        {
            r.p1.X = 3;
            r.p2.X = 3;
            r.p3.X = 3;
            r.p4.X = 3;
        }

        public static void DoStuffWithList(ShapeHolder s, ShapeBase newShape)
        {
            s.AddShape(newShape);
        }
    }
}
