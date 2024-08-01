using DesignPattern.Object;
using DesignPattern.Object.Interface;

namespace DesignPattern.CreationalDesignPattern.FactoryMethodDesignPattern
{
    public class DiamondFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new DiamondCard();
            return product;
        }
    }
}
