using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using Api.Hotel.Rooms.Units;
using Api.Networking.Messages.Outgoing;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Server.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms
{
    public record Room : IRoom
    {
        public uint Id { get; init; }
        public IRoomInfo RoomInfo { get; init; }
        public IRoomModel RoomModel { get; init; }

        private ILogger<IRoom> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }

        public Room(ILogger<IRoom> logger, IRoomInfo roomInfo, IDatabaseContext databaseContext)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            Id = roomInfo.Id;
            RoomInfo = roomInfo;
        }
    }
}
