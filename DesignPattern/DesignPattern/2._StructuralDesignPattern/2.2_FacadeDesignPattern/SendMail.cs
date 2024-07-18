namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class SendMail
    {
        public void Send(ExampleFacadeDesignPattern.User user) => Console.WriteLine($"Send Mail: {user.Email}");
    }
}
