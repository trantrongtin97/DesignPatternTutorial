namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.LoggingProxyDesignPattern
{
    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"LOG: {msg}");
        }
    }
}
