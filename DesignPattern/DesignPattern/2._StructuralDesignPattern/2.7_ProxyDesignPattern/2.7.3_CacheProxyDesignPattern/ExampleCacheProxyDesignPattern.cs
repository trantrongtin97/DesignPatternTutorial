namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CacheProxyDesignPattern
{
    public class ExampleCacheProxyDesignPattern
    {
        public void Run()
        {
            IService service = new CacheProxyService(new ActualService());

            Console.WriteLine(service.GetData(1));
            Console.WriteLine(service.GetData(1));
            Console.WriteLine(service.GetData(2)); 
        }
    }
}
