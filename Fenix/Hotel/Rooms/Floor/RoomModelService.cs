using Api.Hotel.Rooms.Floor;
using Api.Util.Cache;
using Microsoft.Extensions.Logging;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms.Floor
{
    public class RoomModelService : IRoomModelService
    {
        private DatabaseContext dbcontext { get; init; }
        private ILogger<IRoomModelService> logger { get; init; }
        private IBaseCache<IRoomModel> roomModelsCache { get; init; }
        public RoomModelService(DatabaseContext dbcontext, IBaseCache<IRoomModel> roomModelsCache, ILogger<IRoomModelService> logger)
        {
            this.dbcontext = dbcontext;
            this.logger = logger;
            this.roomModelsCache = roomModelsCache;
        }

        public ValueTask DeleteAsync(string key)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IRoomModel?> GetAsync(string key)
        {
            return await roomModelsCache.GetOrCreateAsync(key, async () => await dbcontext.RoomModels.FindAsync(key));
        }

        public ValueTask<List<IRoomModel>> GetAllAsync()
        {
            return new ValueTask<List<IRoomModel>>(dbcontext.RoomModels.ToList<IRoomModel>());
        }

        public ValueTask<IRoomModel> UpdateAsync(IRoomModel product)
        {
            throw new NotImplementedException();
        }
    }
}
