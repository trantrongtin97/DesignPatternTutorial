namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    public class ExampleBridgeDesignPattern
    {
        public void Run()
        {
            AbstractRemoteControl ssRemoteControl = new SamsungRemoteControl(new SamsungTV());
            ssRemoteControl.On();
            ssRemoteControl.ChangeChannel(1114);
            ssRemoteControl.Off();
            
            AbstractRemoteControl snRemoteControl = new SamsungRemoteControl(new SonyTV());
            snRemoteControl.On();
            snRemoteControl.ChangeChannel(1115);
            snRemoteControl.Off();
        }
    }
}
