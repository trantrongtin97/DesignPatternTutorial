namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class RegisterUser
    {
        public void Register(ExampleFacadeDesignPattern.User user) 
        {
            Console.WriteLine("Registing...");
            ValidateUser validater = new();
            validater.Validate(user);
            CreateUser creater = new();
            creater.Create(user);
            SendMail mailer = new();
            mailer.Send(user);
            Console.WriteLine("Register user completed");
        }
    }
}
