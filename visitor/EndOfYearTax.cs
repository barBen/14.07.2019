﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class EndOfYearTax : IVisitor
    {
        public EndOfYearTax()
        {
        }

        public double Visit(Liquor liquor)
        {
            return liquor.Price * 0.8;
        }

        public double Visit(Tabacco tabacco)
        {
            return tabacco.Price * 1.55;
        }

        public double Visit(Chocolate chocolate)
        {
            return chocolate.Price * 0.9;
        }

        public double Visit(Perfume perfume)
        {
            return perfume.Price * 0.3;
        }

        public double Visit(ShopRent shopRent)
        {
            return shopRent.Price * 2;
        }
    }
}
