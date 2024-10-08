﻿using DesignPattern.Object.Interface;

namespace DesignPattern.CreationalDesignPattern.FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }
}
