namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.RemoteProxyDesignPattern
{
    public class RealComputer : IComputer
    {
        private string Ip {  get; set; }
        public void Connect(string ip)
        {
            Ip = ip;
            ShowInfo();
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Conputer {Ip} running in {DateTime.Now}");
        }
    }
}
