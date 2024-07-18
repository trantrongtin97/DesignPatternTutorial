namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.RemoteProxyDesignPattern
{
    public class ExampleRemoteProxyPattern
    {
        
        public void Run()
        {
            IComputer service = new RemoteServiceProxy();
            service.Connect("123");
            service.Connect("789");
            service.Connect("555");
        }
        
    }
}
