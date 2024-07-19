namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CacheProxyDesignPattern
{
    public class CacheProxyService : IService
    {
        private readonly IService _service;
        private readonly Dictionary<int, string> _cache = new Dictionary<int, string>();
        public CacheProxyService(IService service)
        {
            _service = service;
        }
        public string GetData(int id)
        {
            if (_cache.ContainsKey(id))
            {
                Console.WriteLine("Returning cached data for id: " + id);
                return _cache[id];
            }
            string result = _service.GetData(id);
            _cache[id] = result;
            return result;
        }
    }
}
