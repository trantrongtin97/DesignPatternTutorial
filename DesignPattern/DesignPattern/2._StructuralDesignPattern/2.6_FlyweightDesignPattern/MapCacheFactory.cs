namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class MapCacheFactory
    {
        private readonly Dictionary<string, PointCache> _cache = new Dictionary<string, PointCache>();
        public MapCacheFactory() 
        {
            _cache = new Dictionary<string, PointCache>() {
                { "1-1" , new PointCache(1,1,"a") },
                { "1-2" , new PointCache(1,2,"b") },
                { "2-1" , new PointCache(2,1,"c") },
                { "2-2" , new PointCache(2,1,"d") }
            };
        }
        public PointCache GetCache(int x, int y)
        {
            var key = $"{x}-{y}";
            return _cache[key];
        }
    }
}
