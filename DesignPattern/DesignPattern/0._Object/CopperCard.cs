using DesignPattern.Object.Interface;

namespace DesignPattern.Object
{
    public class CopperCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Copper";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
