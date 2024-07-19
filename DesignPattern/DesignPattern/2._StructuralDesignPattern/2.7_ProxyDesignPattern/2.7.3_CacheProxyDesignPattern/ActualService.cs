namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CacheProxyDesignPattern
{
    public class ActualService : IService
    {
        public string GetData(int id)
        {
            Console.WriteLine($"Get Data From DataBase With Id : {id}");
            return $"Data For {id}";
        }
    }
}
