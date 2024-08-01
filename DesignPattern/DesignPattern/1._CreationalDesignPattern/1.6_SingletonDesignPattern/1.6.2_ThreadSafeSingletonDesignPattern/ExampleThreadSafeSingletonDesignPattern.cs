namespace DesignPattern.CreationalDesignPattern.SingletonDesignPattern.ThreadSafeSingletonDesignPattern
{
    public static class ExampleThreadSafeSingletonDesignPattern
    {
        public static void Run()
        {
            Parallel.Invoke(
               //Invoked by Thread-1
               () => RunUsingLockWay(),
               //Invoked by Thread-2
               () => RunDoubleCheckLockWay(),
               //Invoked by Thread-3
               () => RunUsingLazyWay(),
               //Invoked by Thread-4
               () => RunUsingEagerWay()
               );
           
        }
        public static void RunUsingLockWay()
        {
            UsingLock.Singleton fromDev = UsingLock.Singleton.GetInstance();
            fromDev.PrintDetails("From Developer");
            UsingLock.Singleton fromTester = UsingLock.Singleton.GetInstance();
            fromTester.PrintDetails("From Tester");
        }
        public static void RunDoubleCheckLockWay()
        {
            DoubleCheckLocking.Singleton fromDev = DoubleCheckLocking.Singleton.GetInstance();
            fromDev.PrintDetails("From Developer");
            DoubleCheckLocking.Singleton fromTester = DoubleCheckLocking.Singleton.GetInstance();
            fromTester.PrintDetails("From Tester");
        }
        public static void RunUsingLazyWay()
        {
            UsingLazy.Singleton fromDev = UsingLazy.Singleton.GetInstance();
            fromDev.PrintDetails("From Developer");
            UsingLazy.Singleton fromTester = UsingLazy.Singleton.GetInstance();
            fromTester.PrintDetails("From Tester");
        }
        public static void RunUsingEagerWay()
        {
            UsingEagerLoading.Singleton fromDev = UsingEagerLoading.Singleton.GetInstance();
            fromDev.PrintDetails("From Developer");
            UsingEagerLoading.Singleton fromTester = UsingEagerLoading.Singleton.GetInstance();
            fromTester.PrintDetails("From Tester");
        }
    }
}
