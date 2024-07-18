using DesignPattern.Object.Interface;

namespace DesignPattern.Object
{
    public class DiamondCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Diamond";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
