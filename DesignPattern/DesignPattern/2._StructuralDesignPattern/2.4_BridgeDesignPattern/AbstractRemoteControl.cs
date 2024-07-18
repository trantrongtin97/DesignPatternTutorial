using DesignPattern.StructuralDesignPattern.BridgeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    public abstract class AbstractRemoteControl
    {
        protected Itv tv;
        public abstract void On();
        public abstract void Off();
        public abstract void ChangeChannel(int channelNumber);
    }
}
