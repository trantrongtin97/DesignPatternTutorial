using DesignPattern.CreationalDesignPattern.AbstractFactoryDesignPattern;
using DesignPattern.CreationalDesignPattern.BuilderDesignPattern;
using DesignPattern.CreationalDesignPattern.FactoryMethodDesignPattern;
using DesignPattern.CreationalDesignPattern.FluentInterfaceDesignPattern;
using DesignPattern.CreationalDesignPattern.SimpleFactoryDesignPattern;
using DesignPattern.CreationalDesignPattern.SingletonDesignPattern.SimpleSingletonDesignPattern;
using DesignPattern.CreationalDesignPattern.SingletonDesignPattern.ThreadSafeSingletonDesignPattern;

namespace DesignPattern.CreationalDesignPattern
{
    public class CreationalDesignPattern
    {
        public void Basic()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("********************************** Creational Design Pattern ****************************************");
            Console.WriteLine("********************************************* Basic ****************************************");

            ExampleSimpleFactoryDesignPattern exampleSimpleFactoryDesignPattern = new ExampleSimpleFactoryDesignPattern();
            exampleSimpleFactoryDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");

            ExampleFactoryMethodDesignPattern exampleFactoryMethodDesignPattern = new ExampleFactoryMethodDesignPattern();
            exampleFactoryMethodDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");

            ExampleAbstractFactoryDesignPattern exampleAbstractFactoryDesignPattern = new ExampleAbstractFactoryDesignPattern();
            exampleAbstractFactoryDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");

            ExampleBuilderDesignPattern exampleBuilderDesignPattern = new ExampleBuilderDesignPattern();
            exampleBuilderDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");

            ExampleFluentInterfaceDesignPattern exampleFluentInterfaceDesignPattern = new ExampleFluentInterfaceDesignPattern();
            exampleFluentInterfaceDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");

            ExampleSimpleSingletonDesignPattern exampleSimpleSingletonDesignPattern = new ExampleSimpleSingletonDesignPattern();
            exampleSimpleSingletonDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");

            ExampleThreadSafeSingletonDesignPattern.Run();
        }
    }
}
