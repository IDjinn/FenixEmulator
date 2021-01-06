using Api.Hotel.Rooms.Units;
using Api.Networking.Clients;

namespace Api.Hotel.Habbos
{
    public interface IHabbo
    {
        public IClient Client { get; init; }
        public IHabboProfile HabboProfile { get; init; }
        public IRoomUser? RoomUser { get; }
        public bool InRoom { get; }
    }
}
