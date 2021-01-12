using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Api.Hotel.Habbos.Profile;
using Api.Hotel.Rooms.Info;
using Api.Util.Cache;

using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Rooms.Info
{
    public class RoomInfoRepository : IRoomInfoRepository
    {
        private IDatabaseContext dbContext { get; init; }
        private ILogger<IRoomInfoRepository> logger { get; init; }
        private IBaseCache<IRoomInfo> rooomInfosCache { get; init; }
        private IHabboProfileRepository habboProfileRepository { get; init; }
        public RoomInfoRepository(
            IDatabaseContext dbContext,
            IBaseCache<IRoomInfo> rooomInfosCache,
            ILogger<IRoomInfoRepository> logger,
            IHabboProfileRepository habboProfileRepository)
        {
            this.dbContext = dbContext;
            this.rooomInfosCache = rooomInfosCache;
            this.logger = logger;
            this.habboProfileRepository = habboProfileRepository;
        }

        public async ValueTask<IRoomInfo?> GetAsync(uint key)
        {
            var roomInfo = await rooomInfosCache.GetOrCreateAsync(key, async () => await dbContext.RoomInfos.FindAsync(key));
            if (roomInfo is null)
                return roomInfo;

            //var owner = await habboProfileRepository.GetAsync(roomInfo.OwnerId);
            //if (owner is IHabboProfile)
            //    roomInfo.SetOwner(owner);

            return roomInfo;
        }

        public ValueTask<List<IRoomInfo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IRoomInfo> UpdateAsync(IRoomInfo product)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteAsync(uint key)
        {
            throw new NotImplementedException();
        }
    }
}
