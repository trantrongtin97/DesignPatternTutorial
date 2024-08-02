using DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern;
using DesignPattern.BehavioralDesignPattern.IteratorDesignPattern;
using DesignPattern.BehavioralDesignPattern.ObserverDesignPattern;

namespace DesignPattern.BehavioralDesignPattern
{
    public class BehavioralDesignPattern
    {
        public void Basic()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("********************************** Behavioral Design Pattern ****************************************");

            ExampleIteratorDesignPattern exampleIteratorDesignPattern = new ExampleIteratorDesignPattern();
            exampleIteratorDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleObserverDesignPattern exampleobserverDesignPattern = new ExampleObserverDesignPattern();
            exampleobserverDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleChainofResponsibilityDesignPattern exampleChainofResponsibilityDesignPattern = new ExampleChainofResponsibilityDesignPattern();
            exampleChainofResponsibilityDesignPattern.Run();
        }
    }
}
