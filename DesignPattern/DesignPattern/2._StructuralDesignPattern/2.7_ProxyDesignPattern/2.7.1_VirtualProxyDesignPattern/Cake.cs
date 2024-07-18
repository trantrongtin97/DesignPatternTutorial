namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.VirtualProxyDesignPattern
{
    public class Cake : ICake
    {
        public int Pices { get; set; }
        public Cake() 
        {
            MakeCake();
        }
        public void MakeCake()
        {
            Console.WriteLine("Making....");
            Pices = 10;
            Console.WriteLine("Done");
        }
        public void Sell(int num)
        {
            if (Pices >= num)
            {
                Pices -= num;
                Console.WriteLine($"Sell {num} pice");
            }
            else
            {
                Console.WriteLine($"Cannot sell {num} pices ({Pices})");
            }
            
        }
    }
}
