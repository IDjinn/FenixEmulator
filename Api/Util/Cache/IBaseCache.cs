using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Cache
{
    public interface IBaseCache<TItem> 
    {
        public ValueTask<TItem?> GetOrDefaultAsync(object key);
        public ValueTask InsertAllAsync<T>(string keyName, IList<T> values, MemoryCacheEntryOptions? options = null);
        public ValueTask<TItem?> GetOrCreateAsync(object key, Func<ValueTask<TItem>> createItem, MemoryCacheEntryOptions? options = null);
    }
}
