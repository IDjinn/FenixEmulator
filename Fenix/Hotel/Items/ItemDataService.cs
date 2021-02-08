using Api.Hotel.Items;
using Api.Util.Cache;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Hotel.Items
{
    public class ItemDataService : IITemDataService
    {
        private DatabaseContext databaseContext { get; init; }
        private IBaseCache<IItemData> itemsDataCache { get; init; }
        private ILogger<ItemDataService> logger { get; init; }
        public ItemDataService(ILogger<ItemDataService> logger, DatabaseContext databaseContext, IBaseCache<IItemData> itemsDataCache)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            this.itemsDataCache = itemsDataCache;
        }

        public async ValueTask InitAsync()
        {
            logger.LogDebug("Init repository ItemData");

            var items = databaseContext.ItemDatas.ToList();
            await itemsDataCache.InsertAllAsync(nameof(IItemData.Id), items, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromDays(1)));

            logger.LogInformation($"ItemsData suceffuly loaded, contains {items.Count} items definitions.");
        }

        public ValueTask DeleteAsync(ushort key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<IItemData>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IItemData?> GetAsync(ushort key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IItemData> UpdateAsync(IItemData product)
        {
            throw new NotImplementedException();
        }
    }
}
