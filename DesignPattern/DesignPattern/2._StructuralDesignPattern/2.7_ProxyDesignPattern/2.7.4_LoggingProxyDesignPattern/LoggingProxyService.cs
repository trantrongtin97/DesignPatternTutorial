namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.LoggingProxyDesignPattern
{
    public class LoggingProxyService : IService
    {
        private readonly IService _service;
        private readonly ILogger _logger;
        public LoggingProxyService(IService service, ILogger logger)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service)); ;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public void GetData()
        {
            _logger.Log("User Call Service");
            _service.GetData();
        }
    }
}
