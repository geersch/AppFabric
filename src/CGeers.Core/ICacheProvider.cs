using System;

namespace CGeers.Core
{
    public interface ICacheProvider
    {
        void Add(string key, object value);
        void Add(string key, object value, TimeSpan timeout);
        object Get(string key);
        object this[string key] { get; set; }
        bool Remove(string key);
    }
}
