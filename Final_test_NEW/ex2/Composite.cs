using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class composite : Component
    {

        IList<Component> childs = new List<Component>();

        public composite(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int Sum()
        {
            int sum = this.Number;
            foreach (Component curr in childs)
            {
                sum += curr.Sum();
            }
            return sum;
        }

        public override bool IsEven()
        {
            if (this.GetChilds().Count == 0)
            {
                return true;
            } 
            else if (this.Number % 2 == 1)
            {
                return false;
            }
            else
            {
                bool currEven = true;
                foreach (Component currComponent in this.GetChilds())
                {
                    currEven = currEven && currComponent.IsEven();
                }
                return currEven;
            }
        }
    }
}
