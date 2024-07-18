namespace DesignPattern.FactoryDesignPattern.SingletonDesignPattern.SimpleSingletonDesignPattern
{
    public sealed class Singleton
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;
        //This variable is going to store the Singleton Instance
        private static Singleton Instance = null;
        //The following Static Method is going to return the Singleton Instance
        public static Singleton GetInstance()
        {
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new Singleton();
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
