namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    public class Cow : IAnimal
    {
        public string Name { get; set; }
        public Cow(string name)
        {
            Name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
