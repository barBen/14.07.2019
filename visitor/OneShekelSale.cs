﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class OneShekelSale : IVisitor
    {
        public OneShekelSale()
        {
        }

        public double Visit(Liquor liquor)
        {
            return 1;
        }

        public double Visit(Tabacco tabacco)
        {
            return 1;
        }

        public double Visit(Chocolate chocolate)
        {
            return 1;
        }

        public double Visit(Perfume perfume)
        {
            return 1;
        }

        public double Visit(ShopRent shopRent)
        {
            return 1;
        }
    }
}
