using DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern;
using DesignPattern.BehavioralDesignPattern.CommandDesignPattern;
using DesignPattern.BehavioralDesignPattern.InterpreterDesignPattern;
using DesignPattern.BehavioralDesignPattern.IteratorDesignPattern;
using DesignPattern.BehavioralDesignPattern.MediatorDesignPattern;
using DesignPattern.BehavioralDesignPattern.MementoDesignPattern;
using DesignPattern.BehavioralDesignPattern.ObserverDesignPattern;
using DesignPattern.BehavioralDesignPattern.StateDesignPattern;
using DesignPattern.BehavioralDesignPattern.StrategyDesignPattern;
using DesignPattern.BehavioralDesignPattern.TemplateMethodDesignPattern;
using DesignPattern.BehavioralDesignPattern.VisitorDesignPattern;

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

            Console.WriteLine("**************************************************************************************************");
            ExampleStateDesignPattern exampleStateDesignPattern = new ExampleStateDesignPattern();
            exampleStateDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleTemplateMethodDesignPattern exampleTemplateMethodDesignPattern = new ExampleTemplateMethodDesignPattern();
            exampleTemplateMethodDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleCommandDesignPattern exampleCommandDesignPattern = new ExampleCommandDesignPattern();
            exampleCommandDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleVisitorDesignPattern exampleVisitorDesignPattern = new ExampleVisitorDesignPattern();
            exampleVisitorDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleStrategyDesignPattern exampleStrategyDesignPattern = new ExampleStrategyDesignPattern();
            exampleStrategyDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleInterpreterDesignPattern exampleInterpreterDesignPattern = new ExampleInterpreterDesignPattern();    
            exampleInterpreterDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleMediatorDesignPattern exampleMediatorDesignPattern = new ExampleMediatorDesignPattern();
            exampleMediatorDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleMementoDesignPattern exampleMementoDesignPattern = new ExampleMementoDesignPattern();
            exampleMementoDesignPattern.Run();
        }
    }
}
