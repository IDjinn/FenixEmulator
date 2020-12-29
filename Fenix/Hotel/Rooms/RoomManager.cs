using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using Api.Hotel.Rooms.Units;
using Api.Util.Factories.Interfaces;
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
        private BaseCache<IRoomModel> roomModelsCache { get; init; }
        private BaseCache<IRoomInfo> rooomInfosCache { get; init; }
        private ILogger<IRoomManager> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }
        private IRoomFactory roomFactory { get; init; }
        public RoomManager(ILogger<IRoomManager> logger, IRoomFactory roomFactory, IDatabaseContext databaseContext)
        {
            this.logger = logger;
            this.roomFactory = roomFactory;
            this.databaseContext = databaseContext;
            loadedRooms = new ConcurrentDictionary<uint, IRoom>();
            rooomInfosCache = new BaseCache<IRoomInfo>();
            roomModelsCache = new BaseCache<IRoomModel>();
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
            return await roomModelsCache.GetOrCreate(modelName, async () => await databaseContext.RoomModels.FindAsync(modelName));
        }

        public async ValueTask<IRoomInfo?> GetRoomInfoAsync(uint roomId)
        {
            return await rooomInfosCache.GetOrCreate(roomId, async () => await databaseContext.RoomInfos.FindAsync(roomId));
        }
    }
}
