using DesignPattern.DependencyInjectionDesignPattern;

namespace DesignPattern.Main
{
    public class DependencyInjectionDesignPattern
    {
        public void Demo()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("********************************** Dependency Injection Design Pattern ****************************************");
            Console.WriteLine("********************************************* Demo ****************************************");
            ExampleDependencyInjectionDesignPattern exampleDependencyInjectionDesignPattern  = new ExampleDependencyInjectionDesignPattern();
            exampleDependencyInjectionDesignPattern.Run();
        }
    }
}
