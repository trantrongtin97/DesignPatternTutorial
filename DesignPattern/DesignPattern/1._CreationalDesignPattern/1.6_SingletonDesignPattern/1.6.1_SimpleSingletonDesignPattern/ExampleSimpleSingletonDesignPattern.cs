namespace DesignPattern.FactoryDesignPattern.SingletonDesignPattern.SimpleSingletonDesignPattern
{
    public class ExampleSimpleSingletonDesignPattern
    {
        public void Run()
        {
            Singleton fromDev = Singleton.GetInstance();
            fromDev.PrintDetails("From Developer");
            Singleton fromTester = Singleton.GetInstance();
            fromTester.PrintDetails("From Tester");
        }
    }
}
