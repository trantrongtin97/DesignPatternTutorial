namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class PointCache
    {

        public int xPoint { get; }
        public int yPoint { get; }
        public string Content { get; }
        public PointCache(int xPoint, int yPoint, string content)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
            this.Content = content;
        }

        public void ShowInfoPoint()
        {
            Console.WriteLine($"Point Info - X: {xPoint}, Y: {yPoint}, Content: {Content}");
        }
    }
}
