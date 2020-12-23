using Fenix.Database;
using Fenix.Hotel.Rooms.Floor;
using Fenix.Hotel.Rooms.Units;
using Fenix.Util.Cache;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms
{
    sealed class RoomManager : IRoomManager
    {
        private ConcurrentDictionary<uint, IRoom> loadedRooms { get; init; }
        private BaseCache<IRoomModel> roomModelsCache { get; init; }
        private ILogger<IRoomManager> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }
        public RoomManager(ILogger<IRoomManager> logger, IDatabaseContext databaseContext)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            loadedRooms = new ConcurrentDictionary<uint, IRoom>();
            roomModelsCache = new BaseCache<IRoomModel>();
        }

        public ValueTask<IRoom?> LoadRoom(uint roomId)
        {
            if (loadedRooms.TryGetValue(roomId, out IRoom? cachedRoom) && cachedRoom is IRoom)
                return new ValueTask<IRoom?>(cachedRoom);

            // Remove from dict if it is not a valid IRoom.
            loadedRooms.TryRemove(roomId, out _);

            IRoom room = null;// new Room(roomId);
            loadedRooms.TryAdd(roomId, room);

            throw new NotImplementedException();

            // return new ValueTask<IRoom>(room);
        }

        public async ValueTask<IRoomModel?> GetRoomModel(string modelName)
        {
            return await roomModelsCache.GetOrCreate(modelName, async () => await databaseContext.RoomModels.FindAsync(modelName));
        }
    }
}
