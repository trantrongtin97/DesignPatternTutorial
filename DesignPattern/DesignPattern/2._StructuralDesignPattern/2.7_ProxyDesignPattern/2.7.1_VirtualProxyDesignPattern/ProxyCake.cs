namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.VirtualProxyDesignPattern
{
    public class ProxyCake : ICake
    {
        private Cake? cake;
        public ProxyCake() { }
        public void Sell(int num)
        {
            if (cake == null)
            {
                cake = new Cake();
            }
            cake.Sell(num);
            if (cake.Pices == 0) cake = null;
        }
    }
}
