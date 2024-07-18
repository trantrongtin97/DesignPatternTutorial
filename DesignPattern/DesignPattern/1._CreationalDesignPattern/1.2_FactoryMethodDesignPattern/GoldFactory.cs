using DesignPattern.Object;
using DesignPattern.Object.Interface;

namespace DesignPattern.FactoryDesignPattern.FactoryMethodDesignPattern
{
    public class GoldFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new GoldCard();
            return product;
        }
    }
}
