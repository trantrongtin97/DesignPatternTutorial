using DesignPattern.Object;
using DesignPattern.Object.Interface;

namespace DesignPattern.CreationalDesignPattern.SimpleFactoryDesignPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;
            switch (cardType)
            {
                case "Copper":
                    cardDetails = new CopperCard();
                    break;
                case "Gold":
                    cardDetails = new GoldCard();
                    break;
                case "Diamond":
                    cardDetails = new DiamondCard();
                    break;
            }
            return cardDetails;
        }
    }
}
