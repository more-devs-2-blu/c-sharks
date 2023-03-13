using CSharks.NFEs.Services.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace CSharks.NFEs.WebApp.Services
{
    public class CacheMemory : ICacheMemory
    {
        private readonly IMemoryCache _cache;

        public CacheMemory(IMemoryCache cache)
        {
            _cache = cache;
        }

        public T Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Set<T>(string key, T value, TimeSpan expirationTime)
        {
            _cache.Set(key, value, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expirationTime
            });
        }
    }
}
