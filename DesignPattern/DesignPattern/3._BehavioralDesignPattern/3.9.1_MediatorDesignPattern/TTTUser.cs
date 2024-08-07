namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    public abstract class TTTUser
    {
        protected string Name;
        public ITTTGroup group { get; set; }

        public TTTUser(string name)
        {
            this.Name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
