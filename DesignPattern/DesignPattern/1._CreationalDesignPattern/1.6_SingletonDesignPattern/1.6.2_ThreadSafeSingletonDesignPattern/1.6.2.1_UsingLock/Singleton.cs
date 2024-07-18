namespace DesignPattern.FactoryDesignPattern.SingletonDesignPattern.ThreadSafeSingletonDesignPattern.UsingLock
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        private static Singleton Instance = null;
        private static readonly object Instancelock = new object();
        public static Singleton GetInstance()
        {
            //This is thread-safe
            //As long as one thread locks the resource, no other thread can access the resource
            //As long as one thread enters into the Critical Section, 
            //no other threads are allowed to enter the critical section
            lock (Instancelock)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                }
            }
            return Instance;
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
