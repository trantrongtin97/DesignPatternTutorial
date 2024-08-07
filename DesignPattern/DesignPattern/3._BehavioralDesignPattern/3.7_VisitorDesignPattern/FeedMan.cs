namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    internal class FeedMan : IVisitor
    {
        public string Name { get; set; }
        public FeedMan(string name)
        {
            Name = name;
        }
        public void Visit(IAnimal animal)
        {
            Console.WriteLine($"FeedMan: {Name} feeding: {animal.Name}");
        }
    }
}
