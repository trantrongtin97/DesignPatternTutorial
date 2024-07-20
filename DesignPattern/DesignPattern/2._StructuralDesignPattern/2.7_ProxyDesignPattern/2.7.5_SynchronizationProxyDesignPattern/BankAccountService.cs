namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SynchronizationProxyDesignPattern
{
    public class BankAccountService : IBankAccount
    {
        private decimal _balance;
        public BankAccountService(decimal balance)
        {
            _balance = balance;
        }
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Depositing: ${amount}");
            _balance += amount;
            Console.WriteLine($"New Balance: ${_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                Console.WriteLine($"Withdrawing: ${amount}");
                _balance -= amount;
                Console.WriteLine($"New Balance: ${_balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds. Current Balance: ${_balance}");
            }
        }
    }
}
