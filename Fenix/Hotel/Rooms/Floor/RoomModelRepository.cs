using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Hotel.Rooms.Floor;
using Api.Util.Cache;
using Api.Util.Repository;

using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Rooms.Floor
{
    public class RoomModelRepository : IRoomModelRepository<IRoomModel, string>
    {
        private IDatabaseContext dbcontext { get; init; }
        private ILogger<IRoomModelRepository<IRoomModel, string>> logger { get; init; }
        private IBaseCache<IRoomModel> roomModelsCache { get; init; }
        public RoomModelRepository(IDatabaseContext dbcontext, IBaseCache<IRoomModel> roomModelsCache, ILogger<IRoomModelRepository<IRoomModel, string>> logger) {
            this.dbcontext = dbcontext;
            this.logger = logger;
            this.roomModelsCache = roomModelsCache;
        }

        public ValueTask Delete(string key)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IRoomModel?> Get(string key)
        {
            return await roomModelsCache.GetOrCreateAsync(key, async () => await dbcontext.RoomModels.FindAsync(key));
        }

        public ValueTask<List<IRoomModel>> GetAll()
        {
            return new ValueTask<List<IRoomModel>>(dbcontext.RoomModels.ToList<IRoomModel>());
        }

        public ValueTask<IRoomModel> Update(IRoomModel product)
        {
            throw new NotImplementedException();
        }
    }
}
