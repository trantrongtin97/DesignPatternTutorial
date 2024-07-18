using DesignPattern.Object.Interface;

namespace DesignPattern.FactoryDesignPattern.SimpleFactoryDesignPattern
{
    public class ExampleSimpleFactoryDesignPattern
    {
        public void Run()
        {
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Gold");

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
    }
}
