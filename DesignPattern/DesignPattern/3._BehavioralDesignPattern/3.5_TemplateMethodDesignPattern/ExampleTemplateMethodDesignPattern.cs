namespace DesignPattern.BehavioralDesignPattern.TemplateMethodDesignPattern
{
    public class ExampleTemplateMethodDesignPattern
    {
        public void Run()
        {
            Console.WriteLine("Black Coffee Preparation");
            CoffeeTemplate coffee = new BlackCoffee();
            coffee.PrepareCoffe();
            Console.WriteLine();
            Console.WriteLine("White Coffee preparation");
            coffee = new WhiteCoffee();
            coffee.PrepareCoffe();
        }
    }
}
