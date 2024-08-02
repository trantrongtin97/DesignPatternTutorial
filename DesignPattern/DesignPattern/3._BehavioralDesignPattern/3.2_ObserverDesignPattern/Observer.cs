using DesignPattern.BehavioralDesignPattern.ObserverDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.ObserverDesignPattern
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName)
        {
            UserName = userName;
        }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }

        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
