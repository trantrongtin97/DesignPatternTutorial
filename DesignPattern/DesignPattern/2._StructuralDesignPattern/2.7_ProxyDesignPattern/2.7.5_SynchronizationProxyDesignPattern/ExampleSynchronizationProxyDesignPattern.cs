namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SynchronizationProxyDesignPattern
{
    public class ExampleSynchronizationProxyDesignPattern
    {
        public async Task Run()
        {
            BankAccountProxyService proxy = new BankAccountProxyService(1000);

            await Task.Run(() => proxy.Deposit(200));
            await Task.Run(() => proxy.Withdraw(500));
            await Task.Run(() => proxy.Deposit(300));
            await Task.Run(() => proxy.Withdraw(200));
            await Task.Run(() => proxy.Withdraw(1000));
        }
    }
}
