using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Hotel.Items;
using Api.Util.Cache;

using BenchmarkDotNet.Attributes;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Items
{
    public class ItemManager : IItemManager
    {
        private ILogger<IItemManager> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }
        private IBaseCache<IItemData> itemDataCache { get; init; }
        public ItemManager(ILogger<IItemManager> logger, IDatabaseContext databaseContext, IBaseCache<IItemData> itemDataCache)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            this.itemDataCache = itemDataCache;
        }

        [Benchmark]
        public async ValueTask Init()
        {
            var items = GetAllItems();
            await itemDataCache.InsertAllAsync(nameof(IItemData.Id), items, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(6)));
        }

        [Benchmark]
        public IList<IItemData> GetAllItems()
        {
            return databaseContext.ItemDatas.ToList<IItemData>();
        }
    }
}
