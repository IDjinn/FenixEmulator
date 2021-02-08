using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;

using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Rooms
{
    public record Room : IRoom
    {
        public uint Id { get; init; }
        public IRoomInfo RoomInfo { get; init; }
        public IRoomModel RoomModel { get; init; }

        private ILogger<IRoom> logger { get; init; }
        private DatabaseContext databaseContext { get; init; }

        public Room(ILogger<IRoom> logger, IRoomInfo roomInfo, DatabaseContext databaseContext)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            Id = roomInfo.Id;
            RoomInfo = roomInfo;
        }
    }
}
