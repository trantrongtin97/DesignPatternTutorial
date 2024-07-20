namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SmartReferenceProxyDesignPattern
{
    public class ExampleSmartReferenceProxyDesignPattern
    {
        public void Run()
        {
            IDatabaseConnection connection = new DatabaseConnectionProxy();
            connection.ExecuteQuery("Select * from Users");

            connection.ExecuteQuery("Select * from Roles");

            connection.ExecuteQuery("Select * from Product");

            connection.ExecuteQuery("Select * from Cast");

        }
    }
}
