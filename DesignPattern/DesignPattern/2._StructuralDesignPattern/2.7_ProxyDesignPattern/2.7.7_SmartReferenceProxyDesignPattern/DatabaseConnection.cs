namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SmartReferenceProxyDesignPattern
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private string _connectionString;
        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool TryConnect()
        {
            return _connectionString != null;
        }
        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query: {query}");
        }
    }
}
