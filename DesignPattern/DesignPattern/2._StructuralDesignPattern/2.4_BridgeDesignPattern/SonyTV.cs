using DesignPattern.StructuralDesignPattern.BridgeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    internal class SonyTV : Itv
    {
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Change Channel Sony: Number {channelNumber}");
        }

        public void Off()
        {
            Console.WriteLine("Turn off Sony TV");
        }

        public void On()
        {
            Console.WriteLine("Turn on Sony TV");
        }
    }
}
