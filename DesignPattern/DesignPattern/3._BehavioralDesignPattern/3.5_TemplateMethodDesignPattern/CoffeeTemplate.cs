namespace DesignPattern.BehavioralDesignPattern.TemplateMethodDesignPattern
{
    public abstract class CoffeeTemplate
    {
        public void PrepareCoffe()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();
            Console.WriteLine(this.GetType().Name + " is Ready");
        }
        protected abstract void BoilWater();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddCoffeePowder();
    }
}
