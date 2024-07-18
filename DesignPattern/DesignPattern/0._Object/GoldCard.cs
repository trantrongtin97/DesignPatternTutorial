using DesignPattern.Object.Interface;

namespace DesignPattern.Object
{
    public class GoldCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Gold";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
