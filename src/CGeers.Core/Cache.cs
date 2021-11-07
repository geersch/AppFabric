using System;
using Microsoft.Practices.ServiceLocation;

namespace CGeers.Core
{
    public static class Cache
    {
        private static readonly ICacheProvider CacheProvider;

        static Cache()
        {
            CacheProvider =
                (ICacheProvider) ServiceLocator.Current
                                     .GetInstance(typeof (ICacheProvider));
        }

        public static void Add(string key, object value)
        {
            CacheProvider.Add(key, value);
        }

        public static void Add(string key, object value, TimeSpan timeout)
        {
            CacheProvider.Add(key, value, timeout);
        }

        public static object Get(string key)
        {
            return CacheProvider[key];
        }

        public static bool Remove(string key)
        {
            return CacheProvider.Remove(key);
        }
    }
}
