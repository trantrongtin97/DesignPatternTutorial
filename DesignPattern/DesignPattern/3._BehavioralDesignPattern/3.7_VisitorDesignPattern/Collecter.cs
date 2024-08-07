namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    public class Collecter : IVisitor
    {
        public string Name { get; set; }
        public Collecter(string name)
        {
            Name = name;
        }
        public void Visit(IAnimal animal)
        {
            Console.WriteLine($"Harvester: {Name} collects product: {animal.Name}");
        }
    }
}
