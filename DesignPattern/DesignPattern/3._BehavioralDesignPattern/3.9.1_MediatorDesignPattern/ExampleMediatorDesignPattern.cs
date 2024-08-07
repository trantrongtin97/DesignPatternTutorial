namespace DesignPattern.BehavioralDesignPattern.MediatorDesignPattern
{
    public class ExampleMediatorDesignPattern
    {
        public void Run()
        {
            ITTTGroup tttGroupMediator = new ConcreteTTTGroupMediator();
            TTTUser Ram = new ConcreteUser("Ram");
            TTTUser Dave = new ConcreteUser("Dave");
            TTTUser Smith = new ConcreteUser("Smith");
            TTTUser Rajesh = new ConcreteUser("Rajesh");
            TTTUser Sam = new ConcreteUser("Sam");
            TTTUser Pam = new ConcreteUser("Pam");
            TTTUser Anurag = new ConcreteUser("Anurag");
            TTTUser John = new ConcreteUser("John");

            tttGroupMediator.RegisterUser(Ram);
            tttGroupMediator.RegisterUser(Dave);
            tttGroupMediator.RegisterUser(Smith);
            tttGroupMediator.RegisterUser(Rajesh);
            tttGroupMediator.RegisterUser(Sam);
            tttGroupMediator.RegisterUser(Pam);
            tttGroupMediator.RegisterUser(Anurag);
            tttGroupMediator.RegisterUser(John);

            Dave.Send("Welcome to TTT Group");
            Console.WriteLine();
            Rajesh.Send("Hello, What is Design Patterns?");
        }
    }
}
