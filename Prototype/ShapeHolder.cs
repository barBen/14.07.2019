using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ShapeHolder : IProtoType<ShapeHolder>
    {
        private List<ShapeBase> shapeList = new List<ShapeBase>();

        public void AddShape (ShapeBase addShape)
        {
            this.shapeList.Add(addShape);
        }

        public void RemoveShape(ShapeBase reomveShape)
        {
            this.shapeList.Remove(reomveShape);
        }

        public ShapeHolder Clone()
        {
            ShapeHolder shapeHolder = new ShapeHolder();

            foreach (ShapeBase shape in shapeList)
            {
                shapeHolder.AddShape(shape);
            }

            return shapeHolder;
        }

        public override string ToString()
        {
            string print = "Shape list : "; 
    
            foreach (ShapeBase shape in shapeList)
            {
                print += shape.ToString();
            }

            return print;
        }
    }
}
