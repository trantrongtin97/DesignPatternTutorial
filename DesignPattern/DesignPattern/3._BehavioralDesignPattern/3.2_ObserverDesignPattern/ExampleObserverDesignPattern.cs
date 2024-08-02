namespace DesignPattern.BehavioralDesignPattern.ObserverDesignPattern
{
    public class ExampleObserverDesignPattern
    {
        public void Run()
        {
            Subject iphoneMobile = new Subject("XS", 5000, "Out of Stock");

            Observer user1 = new Observer("TTT");
            user1.AddSubscriber(iphoneMobile);

            Observer user2 = new Observer("TL");
            user2.AddSubscriber(iphoneMobile);

            Observer user3 = new Observer("HL");
            user3.AddSubscriber(iphoneMobile);

            Console.WriteLine($"IP Mobile current state : {iphoneMobile.GetAvailability()}");

            user3.RemoveSubscriber(iphoneMobile);
            iphoneMobile.SetAvailability("Available");
        }
    }
}
