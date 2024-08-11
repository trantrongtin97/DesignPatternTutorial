﻿namespace DesignPattern.DependencyInjectionDesignPattern
{
    public class TTTInjector
    {
        private static Dictionary<Type, Type> mappings
           = new Dictionary<Type, Type>();

        public static T Get<T>()
        {
            var type = typeof(T);
            return (T)Get(type);
        }

        private static object Get(Type type)
        {
            var target = ResolveType(type);
            var constructor = target.GetConstructors().FirstOrDefault();
            var parameters = constructor.GetParameters();

            List<object> resolvedParameters = new List<object>();

            foreach (var item in parameters)
            {
                resolvedParameters.Add(Get(item.ParameterType));
            }

            return constructor.Invoke(resolvedParameters.ToArray());
        }

        private static Type ResolveType(Type type)
        {
            if (mappings.Keys.Contains(type))
            {
                return mappings[type];
            }

            return type;
        }

        public static void Map<T, V>() where V : T
        {
            mappings.Add(typeof(T), typeof(V));
        }

        public static void Clear()
        {
            mappings.Clear();
        }
    }
}

