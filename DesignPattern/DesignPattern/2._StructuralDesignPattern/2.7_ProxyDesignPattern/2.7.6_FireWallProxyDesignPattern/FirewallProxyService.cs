namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.FireWallProxyDesignPattern
{
    public class FirewallProxyService : IService
    {
        private AppService _service;
        private List<string> _allowSites;
        public FirewallProxyService()
        {
            _allowSites = new List<string> { "ttt.com", "3t.com" };
        }
        public void Request(string site)
        {
            if (IsRequestValid(site))
            {
                if (_service == null)
                    _service = new AppService();
                _service.Request(site);
            }
            else
            {
                Console.WriteLine($"FirewallProxy: \"{site}\" Access Denied!");
            }
        }
        private bool IsRequestValid(string siteBeingAccessed)
        {
            return _allowSites.Contains(siteBeingAccessed);
        }
    }
}
