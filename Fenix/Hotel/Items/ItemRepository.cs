using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Api.Hotel.Habbos.Profile;
using Api.Hotel.Items;
using Api.Hotel.Rooms.Info;
using Api.Util.Cache;

using Server.Database;

namespace Server.Hotel.Items
{
    public class ItemRepository : IItemRepository
    {
        private DatabaseContext databaseContext;
        private IBaseCache<IItem> itemsCache;
        private IHabboProfileRepository habboProfileRepository;
        private IRoomInfoRepository roomInfoRepository;
        private IItemDataRepository<IItemData, ushort> itemDataRepository;
        public ItemRepository(DatabaseContext databaseContext,
                              IHabboProfileRepository habboProfileRepository,
                              IItemDataRepository<IItemData, ushort> itemDataRepository,
                              IRoomInfoRepository roomInfoRepository,
                              IBaseCache<IItem> itemsCache)
        {
            this.databaseContext = databaseContext;
            this.itemsCache = itemsCache;
            this.habboProfileRepository = habboProfileRepository;
            this.itemDataRepository = itemDataRepository;
            this.roomInfoRepository = roomInfoRepository;
        }

        public ValueTask DeleteAsync(ulong key)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IItem?> GetAsync(ulong key)
        {
            return await itemsCache.GetOrCreateAsync(key, async () =>
            {
                var itemDTO = await databaseContext.Items.FindAsync(key);
                if (itemDTO is null)
                    return null;

                var itemData = await itemDataRepository.GetAsync(itemDTO.ItemDataId);
                if (itemData is null)
                    throw new NullReferenceException($"ItemData '{itemDTO.ItemDataId}' wasn't found.");

                var owner = await habboProfileRepository.GetAsync(itemDTO.OwnerId);
                if (owner is null)
                    throw new NullReferenceException($"ItemData '{itemDTO.OwnerId}' wasn't found.");

                if (itemDTO.RoomInfoId is uint roomId)
                {
                    var roomInfo = await roomInfoRepository.GetAsync(roomId);
                    return new Item(itemDTO, itemData, owner, roomInfo);
                }

                return new Item(itemDTO, itemData, owner);
            });
        }

        public ValueTask<List<IItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IItem> UpdateAsync(IItem product)
        {
            throw new NotImplementedException();
        }
    }
}
