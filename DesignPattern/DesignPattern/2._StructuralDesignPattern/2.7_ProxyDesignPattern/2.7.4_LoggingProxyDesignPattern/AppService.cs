namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.LoggingProxyDesignPattern
{
    public class AppService : IService
    {
        public void GetData()
        {
            Console.WriteLine("Service Getting Data");
        }
    }
}
