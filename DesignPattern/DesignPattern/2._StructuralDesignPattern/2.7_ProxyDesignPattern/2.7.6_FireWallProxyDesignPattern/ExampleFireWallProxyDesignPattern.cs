namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.FireWallProxyDesignPattern
{
    public class ExampleFireWallProxyDesignPattern
    {
        public void Run()
        {
            IService proxy = new FirewallProxyService();
            proxy.Request("ttt.com");
            proxy.Request("3t.com");
            proxy.Request("4t.com");
        }
    }
}
