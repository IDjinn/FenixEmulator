using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fenix.Util.Cache
{
    // Tanks https://michaelscodingspot.com/cache-implementations-in-csharp-net/
    public class BaseCache<TItem>
    {
        private MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
        private ConcurrentDictionary<object, SemaphoreSlim> locks = new ConcurrentDictionary<object, SemaphoreSlim>();

        public async ValueTask<TItem> GetOrCreate(object key, Func<Task<TItem>> createItem, MemoryCacheEntryOptions? options)
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
                        cache.Set(key, cacheEntry, options);
                    }
                }
                finally
                {
                    @lock.Release();
                }
            }

            return cacheEntry!;
        }
    }
}
