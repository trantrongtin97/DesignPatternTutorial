namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.VirtualProxyDesignPattern
{
    public class ExampleVirsualProxyDesignPattern
    {
        public void Run()
        {
            ICake cake = new ProxyCake();
            cake.Sell(2);
            cake.Sell(5);
            cake.Sell(5);
            cake.Sell(3);
            cake.Sell(2);
            cake.Sell(1);
            cake.Sell(3);
            cake.Sell(4);
            cake.Sell(5);
        }
    }
}
