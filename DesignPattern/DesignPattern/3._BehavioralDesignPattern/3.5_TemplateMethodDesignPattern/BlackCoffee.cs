namespace DesignPattern.BehavioralDesignPattern.TemplateMethodDesignPattern
{
    public class BlackCoffee : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        protected override void AddMilk()
        {
            Console.WriteLine("No Milk Added");
        }
        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("No Coffee Powder Added");
        }
    }
}
