namespace DesignPattern.BehavioralDesignPattern.TemplateMethodDesignPattern
{
    public class WhiteCoffee : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }
        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Fresh Milk Coffee Powder Added");
        }
    }
}
