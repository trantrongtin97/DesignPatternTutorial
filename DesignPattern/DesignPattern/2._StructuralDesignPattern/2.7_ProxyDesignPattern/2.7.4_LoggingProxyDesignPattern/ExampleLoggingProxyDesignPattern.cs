namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.LoggingProxyDesignPattern
{
    public class ExampleLoggingProxyDesignPattern
    {
        public void Run()
        {
            IService service = new AppService();
            ILogger logger = new Logger();
            IService proxy = new LoggingProxyService(service, logger);

            proxy.GetData();
        }
    }
}
