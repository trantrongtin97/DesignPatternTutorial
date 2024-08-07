using DesignPattern.BehavioralDesignPattern.StateDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.StateDesignPattern
{
    public class DebitCardNotInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }

        public void EnterPin()
        {
            Console.WriteLine("You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("you cannot enter the pin, as No Debit Card in ATM Machine slot");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("you cannot withdraw money, as No Debit Card in ATM Machine slot");
        }
    }
}
