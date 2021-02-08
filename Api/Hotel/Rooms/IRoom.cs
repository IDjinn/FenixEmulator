using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;

namespace Api.Hotel.Rooms
{
    public interface IRoom
    {
        public uint Id { get; init; }
        public IRoomInfo RoomInfo { get; init; }
        public IRoomModel RoomModel { get; init; }
    }
}
