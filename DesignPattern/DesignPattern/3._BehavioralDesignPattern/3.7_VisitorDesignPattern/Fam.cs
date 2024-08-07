namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    public class Fam
    {
        private static readonly List<IAnimal> animals = new List<IAnimal>();
        static Fam()
        {
            animals = new List<IAnimal>
            {
                new Chicken("Male Chicken"),
                new Chicken("FeMale Chicken"),
                new Cow("Milk Cow"),
                new Cow("Wagu Cow")
            };
        }
        public void Activity(IVisitor visitor)
        {
            foreach (var animal in animals)
            {
                animal.Accept(visitor);
            }
        }
    }
}
