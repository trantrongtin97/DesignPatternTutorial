namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.RemoteProxyDesignPattern
{
    public class RemoteServiceProxy : IComputer
    {
        public Dictionary<string, string> DemoDataIp = new Dictionary<string, string>()
        {
            { "123","234" },
            { "345","543" },
            { "678","765" },
            { "789","987" },
        };
        public void Connect(string ip)
        {
            RemoteCall(ip);
        }
        private void RemoteCall(string ip)
        {
            var realIp = DemoDataIp.FirstOrDefault(k => k.Key == ip).Value;
            if (realIp != null)
            {
                IComputer comp = new RealComputer();
                comp.Connect(realIp);
            }
            else
            {
                Console.WriteLine("Incorrect IP");
            }
            
        }
    }
}
