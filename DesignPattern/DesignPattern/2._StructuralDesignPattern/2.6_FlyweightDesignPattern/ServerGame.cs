namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class ServerGame
    {
        private readonly List<Character> characters = new List<Character>();
        private readonly MapCacheFactory mapCacheFactory = new MapCacheFactory();

        public void RegisterCharacter(string name ,int exp, int xPoint, int yPoint)
        {
            var point = mapCacheFactory.GetCache(xPoint, yPoint);
            characters.Add(new Character(name, exp, point));
        }

        public void LoadServer()
        {
            foreach (var c in characters)
            {
                c.Display();
            }
        }
    }
}
