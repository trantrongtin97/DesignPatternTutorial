using DesignPattern.StructuralDesignPattern.BridgeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    public class SamsungTV : Itv
    {
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Change Channel Samsung: Number {channelNumber}");
        }

        public void Off()
        {
            Console.WriteLine("Turn off Samsung TV");
        }

        public void On()
        {
            Console.WriteLine("Turn on Samsung TV");
        }
    }
}
