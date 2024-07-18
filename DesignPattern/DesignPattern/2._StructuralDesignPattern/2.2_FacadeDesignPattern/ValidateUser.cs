namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class ValidateUser
    {
        public void Validate(ExampleFacadeDesignPattern.User user) => Console.WriteLine($"Validate User: {user.Name}");
    }
}
