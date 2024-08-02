namespace DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern
{
    public class ExampleChainofResponsibilityDesignPattern
    {
        public void Run()
        {
            ATM atm = new ATM();
            Console.WriteLine("Requested Amount 5600");
            atm.Withdraw(5600);
        }
    }
}
