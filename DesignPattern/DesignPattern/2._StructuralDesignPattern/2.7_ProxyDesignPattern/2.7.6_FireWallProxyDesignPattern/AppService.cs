namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.FireWallProxyDesignPattern
{
    public class AppService : IService
    {
        public void Request(string site)
        {
            Console.WriteLine($"Handling Request : {site}");
        }
    }
}
