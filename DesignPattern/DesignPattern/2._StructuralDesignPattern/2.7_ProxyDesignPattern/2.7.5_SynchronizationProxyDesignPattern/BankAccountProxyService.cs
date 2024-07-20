namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SynchronizationProxyDesignPattern
{
    public class BankAccountProxyService : IBankAccount
    {
        private readonly IBankAccount _bankAccount;
        private readonly object _syncLock = new object();
        public BankAccountProxyService(decimal initialBalance)
        {
            _bankAccount = new BankAccountService(initialBalance);
        }
        public void Deposit(decimal amount)
        {
            lock (_syncLock)
            {
                _bankAccount.Deposit(amount);
            }
        }

        public void Withdraw(decimal amount)
        {
            lock (_syncLock)
            {
                _bankAccount.Withdraw(amount);
            }
        }
    }
}
