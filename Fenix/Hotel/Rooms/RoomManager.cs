using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using Api.Util.Factories.Hotel.Rooms;
using Microsoft.Extensions.Logging;
using Server.Database;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms
{
    sealed class RoomManager : IRoomManager
    {
        private ConcurrentDictionary<uint, IRoom> loadedRooms { get; init; }
        private ILogger<IRoomManager> logger { get; init; }
        private DatabaseContext databaseContext { get; init; }
        private IRoomFactory roomFactory { get; init; }
        private IRoomInfoService roomInfoRepository { get; init; }
        private IRoomModelService roomModelRepository { get; init; }


        public RoomManager(ILogger<IRoomManager> logger,
                           IRoomFactory roomFactory,
                           DatabaseContext databaseContext,
                           IRoomInfoService roomInfoRepository,
                           IRoomModelService roomModelRepository)
        {
            this.logger = logger;
            this.roomFactory = roomFactory;
            this.databaseContext = databaseContext;
            this.loadedRooms = new ConcurrentDictionary<uint, IRoom>();
            this.roomModelRepository = roomModelRepository;
            this.roomInfoRepository = roomInfoRepository;
        }

        public async ValueTask<IRoom?> LoadRoomAsync(uint roomId)
        {
            if (loadedRooms.TryGetValue(roomId, out IRoom? cachedRoom))
                return cachedRoom;

            var roomInfo = await roomInfoRepository.GetAsync(roomId);
            if (roomInfo is not IRoomInfo)
                return null;

            IRoom room = roomFactory.Create(roomInfo);
            loadedRooms.TryAdd(roomId, room);
            return room;
        }
    }
}
