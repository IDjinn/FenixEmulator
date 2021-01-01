using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using Api.Hotel.Rooms.Units;
using Api.Util.Cache;
using Api.Util.Factories.Hotel.Rooms;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Server.Database;
using Server.Util.Cache;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms
{
    sealed class RoomManager : IRoomManager
    {
        private ConcurrentDictionary<uint, IRoom> loadedRooms { get; init; }
        private IBaseCache<IRoomModel> roomModelsCache { get; init; }
        private IBaseCache<IRoomInfo> rooomInfosCache { get; init; }
        private ILogger<IRoomManager> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }
        private IRoomFactory roomFactory { get; init; }
        public RoomManager(ILogger<IRoomManager> logger,
                           IRoomFactory roomFactory,
                           IDatabaseContext databaseContext,
                           IBaseCache<IRoomInfo> rooomInfosCache,
                           IBaseCache<IRoomModel> roomModelsCache)
        {
            this.logger = logger;
            this.roomFactory = roomFactory;
            this.databaseContext = databaseContext;
            this.loadedRooms = new ConcurrentDictionary<uint, IRoom>();
            this.rooomInfosCache = rooomInfosCache;
            this.roomModelsCache = roomModelsCache;
        }

        public async ValueTask<IRoom?> LoadRoomAsync(uint roomId)
        {
            if (loadedRooms.TryGetValue(roomId, out IRoom? cachedRoom) && cachedRoom is IRoom)
                return cachedRoom;

            // Remove from dict if it is not a valid IRoom.
            loadedRooms.TryRemove(roomId, out _);

            var roomInfo = await GetRoomInfoAsync(roomId);
            if (roomInfo is not IRoomInfo)
                return null;

            IRoom room = roomFactory.Create(roomInfo);
            loadedRooms.TryAdd(roomId, room);
            return room;
        }

        public async ValueTask<IRoomModel?> GetRoomModelAsync(string modelName)
        {
            return await roomModelsCache.GetOrCreateAsync(modelName, async () => await databaseContext.RoomModels.FindAsync(modelName));
        }

        public async ValueTask<IRoomInfo?> GetRoomInfoAsync(uint roomId)
        {
            return await rooomInfosCache.GetOrCreateAsync(roomId, async () => await databaseContext.RoomInfos.FindAsync(roomId));
        }
    }
}
