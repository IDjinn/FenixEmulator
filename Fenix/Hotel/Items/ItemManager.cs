using Api.Hotel.Items;
using Api.Util.Cache;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Server.Database;
using Server.Util.Cache;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            LoadItemsAsync();
        }

        private async ValueTask<IList<IItemData>> LoadItemsAsync()
        {
            var items = databaseContext.ItemDatas.ToList<IItemData>();
            await itemDataCache.InsertAllAsync(nameof(IItemData.Id), items, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(6)));
            return items;
        }
    }
}
