using Fenix.Database;
using Fenix.Util.Cache;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Items
{
    public class ItemManager : IItemManager
    {
        private ILogger<IItemManager> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }
        private BaseCache<IItemData> itemDataCache { get; init; }
        public ItemManager(ILogger<IItemManager> logger, IDatabaseContext databaseContext)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            itemDataCache = new BaseCache<IItemData>();

            LoadItemsAsync();
        }

        private IList<ItemData> LoadItemsAsync()
        {
            var items = databaseContext.ItemDatas.ToList();
            itemDataCache.InsertAll(nameof(IItemData.Id), items, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(6)));
            return items;
        }
    }
}
