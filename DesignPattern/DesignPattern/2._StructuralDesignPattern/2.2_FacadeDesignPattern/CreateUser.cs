namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class CreateUser
    {
        public void Create(ExampleFacadeDesignPattern.User user) => Console.WriteLine($"Created User {user.Name}: Id ({new Random().Next(1,10)})");
    }
}
