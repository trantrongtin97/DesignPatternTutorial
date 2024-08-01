namespace DesignPattern.CreationalDesignPattern.SingletonDesignPattern.ThreadSafeSingletonDesignPattern.UsingLazy
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        private static readonly Lazy<Singleton> SingleInstance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance()
        {
            return SingleInstance.Value;
        }
        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
