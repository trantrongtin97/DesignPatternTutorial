namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    public interface IAnimal
    {
        public string Name { get; set; }
        void Accept(IVisitor visitor);
    }
}
