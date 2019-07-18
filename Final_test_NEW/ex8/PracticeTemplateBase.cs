using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public abstract class PracticeTemplateBase : TemplateQueryRunner
    {
        protected override void ChangeClothes()
        {
            Console.WriteLine("Changing clothes");
        }
        protected override void DrinkWater()
        {
            Console.WriteLine("Drinking water");
        }
        protected override void MakeShower()
        {
            Console.WriteLine("Making shower");
        }
    }
}
