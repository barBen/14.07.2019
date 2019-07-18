using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public abstract class TemplateQueryRunner
    {
        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void ExecuteWork();
        protected abstract void MakeShower();
            
        public void Run()
        {
            ChangeClothes();
            DrinkWater();
            ExecuteWork();
            MakeShower();
        }
    }
}
