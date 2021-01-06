using System.ComponentModel.DataAnnotations.Schema;

using Api.Hotel.Habbos;
using Api.Hotel.Rooms.Units;
using Api.Networking.Clients;

using Microsoft.Extensions.Logging;

namespace Server.Hotel.Habbos
{
    [NotMapped]
    public sealed record Habbo : IHabbo
    {
        public IClient Client { get; init; }
        public IHabboProfile HabboProfile { get; init; }
        public IRoomUser? RoomUser { get; private set; }
        public ILogger<IHabbo> logger { get; init; }

        public bool InRoom => RoomUser is IRoomUser;

        public Habbo(ILogger<IHabbo> logger, IClient client, IHabboProfile habboProfile) => (this.logger, Client, HabboProfile) = (logger, client, habboProfile);

        public void SetRoomUser(IRoomUser? roomUser)
        {
            RoomUser = roomUser;
        }
    }
}
