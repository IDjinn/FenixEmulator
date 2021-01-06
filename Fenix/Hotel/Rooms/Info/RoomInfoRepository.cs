using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Hotel.Habbos;
using Api.Hotel.Rooms.Info;
using Api.Util.Cache;
using Api.Util.Repository;

using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Rooms.Info
{
    public class RoomInfoRepository : IRoomInfoRepository<IRoomInfo, uint> 
    {
        private IDatabaseContext dbContext { get; init; }
        private ILogger<IRoomInfoRepository<IRoomInfo, uint>> logger { get; init; }
        private IHabboManager habboManager { get; init; }
        private IBaseCache<IRoomInfo> rooomInfosCache { get; init; }
        public RoomInfoRepository(IDatabaseContext dbContext, IBaseCache<IRoomInfo> rooomInfosCache, ILogger<IRoomInfoRepository<IRoomInfo, uint>> logger, IHabboManager habboManager)
        {
            this.dbContext = dbContext;
            this.rooomInfosCache = rooomInfosCache;
            this.logger = logger;
            this.habboManager = habboManager;
        }

        public ValueTask<List<IRoomInfo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IRoomInfo?> Get(uint key)
        {
            var roomInfo = await rooomInfosCache.GetOrCreateAsync(key, async () => await dbContext.RoomInfos.FindAsync(key));
            if (roomInfo is null)
                return roomInfo;

            var owner = await habboManager.GetProfileAsync(key);
            if (owner is IHabboProfile)
                roomInfo.SetOwner(owner);

            return roomInfo;
        }

        ValueTask<IRoomInfo> GenericRepository<IRoomInfo, uint>.Update(IRoomInfo product)
        {
            throw new NotImplementedException();
        }

        public ValueTask Delete(uint key)
        {
            throw new NotImplementedException();
        }
    }
}
