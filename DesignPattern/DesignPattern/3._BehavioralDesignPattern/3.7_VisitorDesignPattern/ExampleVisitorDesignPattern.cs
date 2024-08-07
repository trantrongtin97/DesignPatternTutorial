namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    public class ExampleVisitorDesignPattern
    {
        public void Run()
        {
            Fam fam = new Fam();
            var visitor1 = new FeedMan("3T");
            fam.Activity(visitor1);

            var visitor2 = new Collecter("4T");
            fam.Activity(visitor2);
        }
    }
}
