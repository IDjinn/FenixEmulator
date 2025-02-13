﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Api.Util.Cache;

using Microsoft.Extensions.Caching.Memory;

namespace Server.Util.Cache
{
    // Tanks https://michaelscodingspot.com/cache-implementations-in-csharp-net/
    public class BaseCache<TItem> : IBaseCache<TItem>
    {
        private static readonly object locker = new object();
        private MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
        private ConcurrentDictionary<object, SemaphoreSlim> locks = new ConcurrentDictionary<object, SemaphoreSlim>();
        private MemoryCacheEntryOptions defaultCacheEntryOptions { get; init; }

        public BaseCache(MemoryCacheEntryOptions? defaultCacheEntryOptions = null)
        {
            this.defaultCacheEntryOptions = defaultCacheEntryOptions ?? new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromHours(4))
            .SetSlidingExpiration(TimeSpan.FromMinutes(30));
        }

        public async ValueTask<TItem?> GetOrCreateAsync(object key, Func<ValueTask<TItem?>> createItem, MemoryCacheEntryOptions? options = null)
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
                finally
                {
                    @lock.Release();
                }
            }
            return cacheEntry;
        }

        public async ValueTask<TItem?> GetAsyncOrCreate(object key, Func<TItem?> createItem, MemoryCacheEntryOptions? options = null)
        {
            if (!cache.TryGetValue(key, out TItem? cacheEntry))
            {
                SemaphoreSlim @lock = locks.GetOrAdd(key, k => new SemaphoreSlim(1, 1));
                await @lock.WaitAsync();
                try
                {
                    if (!cache.TryGetValue(key, out cacheEntry))
                    {
                        cacheEntry = createItem();
                        cache.Set(key, cacheEntry, options ?? defaultCacheEntryOptions);
                    }
                }
                finally
                {
                    @lock.Release();
                }
            }
            return cacheEntry;
        }


        public async ValueTask InsertAllAsync<T>(string keyName, IList<T> values, MemoryCacheEntryOptions? options = null)
        {
            var keyProperty = typeof(T).GetProperty(keyName);
            if (keyProperty is null)
                throw new ArgumentNullException(nameof(keyProperty));

            foreach (var item in values)
            {
                lock (locker)
                {
                    var key = keyProperty.GetValue(item);
                    cache.Set(key, item, options ?? defaultCacheEntryOptions);
                }
            }
        }

        public async ValueTask<TItem?> GetOrDefaultAsync(object key)
        {
            cache.TryGetValue(key, out TItem? cacheEntry);
            return cacheEntry;
        }
    }
}
