﻿using DesignPattern.Object;
using DesignPattern.Object.Interface;

namespace DesignPattern.CreationalDesignPattern.FactoryMethodDesignPattern
{
    public class CopperFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new CopperCard();
            return product;
        }
    }
}
