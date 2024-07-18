namespace DesignPattern.FactoryDesignPattern.SingletonDesignPattern.ThreadSafeSingletonDesignPattern.UsingEagerLoading
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        private static readonly Singleton singleInstance = new Singleton();

        public static Singleton GetInstance()
        {
            return singleInstance;
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
