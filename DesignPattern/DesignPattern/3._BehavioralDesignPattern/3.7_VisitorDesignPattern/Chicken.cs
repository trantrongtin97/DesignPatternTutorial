namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    public class Chicken : IAnimal
    {
        public string Name { get; set; }
        public Chicken(string name)
        {
            Name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
