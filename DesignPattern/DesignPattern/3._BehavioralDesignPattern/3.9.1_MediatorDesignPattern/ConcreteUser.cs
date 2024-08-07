namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    public class ConcreteUser : TTTUser
    {
        public ConcreteUser(string Name) : base(Name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message=" + message + "\n");
            group.SendMessage(message, this);
        }
    }
}
