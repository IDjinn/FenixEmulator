using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Api.Hotel.Items;
using Api.Util.Cache;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Items
{
    public class ItemDataRepository : IItemDataRepository<ItemData, ushort>
    {
        private IDatabaseContext databaseContext { get; init; }
        private IBaseCache<ItemData> itemsDataCache { get; init; }
        private ILogger<ItemDataRepository> logger { get; init; }
        public ItemDataRepository(ILogger<ItemDataRepository> logger, IDatabaseContext databaseContext, IBaseCache<ItemData> itemsDataCache)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            this.itemsDataCache = itemsDataCache;
        }

        public async ValueTask InitAsync()
        {
            var items = await LoadItemsDataAsync();
            await itemsDataCache.InsertAllAsync(nameof(ItemData.Id), items, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromDays(1)));
        }

        private async ValueTask<List<ItemData>> LoadItemsDataAsync()
        {
            return databaseContext.ItemDatas.Include(nameof(ItemData.Id)).ToList();
        }

        public ValueTask DeleteAsync(ushort key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<ItemData>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<ItemData?> GetAsync(ushort key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ItemData> UpdateAsync(ItemData product)
        {
            throw new NotImplementedException();
        }
    }
}
