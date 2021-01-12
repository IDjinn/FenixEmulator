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
        private IDatabaseContext databaseContext;
        private IBaseCache<IItem> itemsCache;
        private IHabboProfileRepository habboProfileRepository;
        private IRoomInfoRepository roomInfoRepository;
        public ItemRepository(IDatabaseContext databaseContext,
                              IHabboProfileRepository habboProfileRepository,
                              IRoomInfoRepository roomInfoRepository,
                              IBaseCache<IItem> itemsCache)
        {
            this.databaseContext = databaseContext;
            this.itemsCache = itemsCache;
            this.habboProfileRepository = habboProfileRepository;
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
                var item = await databaseContext.Items.FindAsync(key);
                if (item is null)
                    return item;

                var owner = await habboProfileRepository.GetAsync(item.OwnerId);
                if (owner is not null)
                    item.SetOwner(owner);

                if (item.RoomInfoId is uint roomId)
                {
                    var roomInfo = await roomInfoRepository.GetAsync(roomId);
                    if (roomInfo is not null)
                        item.SetRoomInfo(roomInfo);
                }

                return item;
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
