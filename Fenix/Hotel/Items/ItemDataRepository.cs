using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Hotel.Items;
using Api.Util.Cache;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Items
{
    public class ItemDataRepository : IItemDataRepository<IItemData, ushort>
    {
        private IDatabaseContext databaseContext { get; init; }
        private IBaseCache<IItemData> itemsDataCache { get; init; }
        private ILogger<ItemDataRepository> logger { get; init; }
        public ItemDataRepository(ILogger<ItemDataRepository> logger, IDatabaseContext databaseContext, IBaseCache<IItemData> itemsDataCache)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            this.itemsDataCache = itemsDataCache;
        }

        public async ValueTask InitAsync()
        {
            var items = databaseContext.ItemDatas.ToList();
            await itemsDataCache.InsertAllAsync(nameof(IItemData.Id), items, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromDays(1)));
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
