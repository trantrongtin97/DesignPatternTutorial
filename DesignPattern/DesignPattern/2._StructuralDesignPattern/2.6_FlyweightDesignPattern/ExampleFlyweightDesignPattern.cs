namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class ExampleFlyweightDesignPattern
    {
        public void Run()
        {
            ServerGame server = new ServerGame();

            server.RegisterCharacter("TT", 300, 1, 2);
            server.RegisterCharacter("TL", 200, 2, 2);

            server.LoadServer();
        }
    }
}
