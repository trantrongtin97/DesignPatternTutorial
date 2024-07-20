namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SmartReferenceProxyDesignPattern
{
    public class DatabaseConnectionProxy : IDatabaseConnection
    {
        private DatabaseConnection _connection;
        private static List<DatabaseConnection> _availableConnections = new List<DatabaseConnection>
        {
            new DatabaseConnection(null), new DatabaseConnection("database1"), new DatabaseConnection("database2")
        };
        public DatabaseConnectionProxy()
        {
            _connection = GetConnectionFromPool();
        }
        public void ExecuteQuery(string query)
        {
            Console.WriteLine("Proxy: Checking connection health...");
            if (ConnectionIsHealthy())
            {
                _connection.ExecuteQuery(query);
                ReturnConnectionToPool(_connection);
            }
            else
            {
                Console.WriteLine("Proxy: Connection is unhealthy. Trying another one...");
                _connection = GetConnectionFromPool();
                _connection.ExecuteQuery(query);
                ReturnConnectionToPool(_connection);
            }
        }
        private DatabaseConnection GetConnectionFromPool()
        {
            var connection = _availableConnections.FirstOrDefault();
            _availableConnections.Remove(connection);
            return connection;
        }
        private void ReturnConnectionToPool(DatabaseConnection connection)
        {
            _availableConnections.Add(connection);
        }
        private bool ConnectionIsHealthy()
        {
            return _connection.TryConnect();
        }
    }
}
