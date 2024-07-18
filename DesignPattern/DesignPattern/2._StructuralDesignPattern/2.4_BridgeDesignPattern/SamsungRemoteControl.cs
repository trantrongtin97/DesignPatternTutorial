using DesignPattern.StructuralDesignPattern.BridgeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(Itv tv) 
        { 
            this.tv = tv;
        }
        public override void ChangeChannel(int channelNumber)
        {
            tv.ChangeChannel(channelNumber);
        }

        public override void Off()
        {
            tv.Off();
        }

        public override void On()
        {
            tv.On();
        }
    }
}
