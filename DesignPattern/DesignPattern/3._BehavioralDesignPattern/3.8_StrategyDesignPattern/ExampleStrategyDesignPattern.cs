using DesignPattern.BehavioralDesignPattern.StrategyDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.StrategyDesignPattern
{
    public class ExampleStrategyDesignPattern
    {
        public void Run()
        {
            ICompression strategy = new ZipCompression();
            CompressionContext ctx = new CompressionContext(strategy);
            ctx.CreateArchive("StrategyDesignPattern");
            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("StrategyDesignPattern");
        }
    }
}
