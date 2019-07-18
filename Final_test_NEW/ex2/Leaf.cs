using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Leaf :  Component
    {
        public Leaf(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            throw new Exception("Leaf elemnt cannot have a child");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new Exception("Leaf elemnt cannot remove a child");
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
        }

        public override int Sum()
        {
            return this.Number;
        }

        public override bool IsEven()
        {
            if(this.Number % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
