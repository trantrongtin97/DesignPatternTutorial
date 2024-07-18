namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class Character
    {
        private readonly PointCache cache;
        public string Name { get; }
        public int Exp { get; }

        public Character(string name, int exp, PointCache cache)
        {
            this.Name = name;
            this.Exp = exp;
            this.cache = cache;
        }
        public void Display()
        {
            Console.WriteLine($"Character Name:{Name} - Exp:{Exp}");
            cache.ShowInfoPoint();
        }
    }
}
