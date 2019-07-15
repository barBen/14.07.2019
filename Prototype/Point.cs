using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Point : ShapeBase
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Point : (X = {X} , Y = {Y})";
        }


        public override ShapeBase Clone()
        {
            return new Point(this.X, this.Y);
        }
    }
}