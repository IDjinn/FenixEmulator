using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Util.Cache
{
    // Tanks https://michaelscodingspot.com/cache-implementations-in-csharp-net/
    public class BaseCache<TItem>
    {
        private static readonly object locker = new object();
        private MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
        private ConcurrentDictionary<object, SemaphoreSlim> locks = new ConcurrentDictionary<object, SemaphoreSlim>();
        private static readonly MemoryCacheEntryOptions defaultCacheEntryOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromHours(4))
            .SetSlidingExpiration(TimeSpan.FromMinutes(30));

        public async ValueTask<TItem?> GetOrCreate(object key, Func<ValueTask<TItem>> createItem, MemoryCacheEntryOptions? options = null)
        {
            if (!cache.TryGetValue(key, out TItem? cacheEntry))
            {
                SemaphoreSlim @lock = locks.GetOrAdd(key, k => new SemaphoreSlim(1, 1));
                await @lock.WaitAsync();
                try
                {
                    if (!cache.TryGetValue(key, out cacheEntry))
                    {
                        cacheEntry = await createItem();
                        cache.Set(key, cacheEntry, options ?? defaultCacheEntryOptions);
                    }
                }
                catch(Exception e)
                {

                }
                finally
                {
                    @lock.Release();
                }
            }
            return cacheEntry;
        }

        public async ValueTask InsertAll<T>(string keyName, IList<T> values, MemoryCacheEntryOptions? options = null)
        {
            var keyProperty = typeof(T).GetProperty(keyName);
            for (int i = 0; i < values.Count; i++)
            {
                lock (locker)
                {
                    var @value = values[i];
                    var key = keyProperty.GetValue(@value);
                    cache.Set(key, @value, options ?? defaultCacheEntryOptions);
                }
            }
        }
    }
}
