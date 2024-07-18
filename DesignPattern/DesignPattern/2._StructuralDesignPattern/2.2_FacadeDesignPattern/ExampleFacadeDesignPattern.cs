namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class ExampleFacadeDesignPattern
    {
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
        public void Run()
        {
            var user = new User() { Name = "TT", Email = "TT.email" };

            //Normal way
            //ValidateUser validater = new();
            //validater.Validate(user);
            //CreateUser creater = new();
            //creater.Create(user);
            //SendMail mailer = new();
            //mailer.Send(user);
            //Console.WriteLine("Register user completed");
            //===========

            //Facade Design Pattern
            var register = new RegisterUser();
            register.Register(user);
        }
    }
}
