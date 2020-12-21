using System.Drawing;

namespace Fenix.Hotel.Rooms.Floor
{
    internal interface IRoomMap
    {
        public IRoom Room { get; init; }
        public IRoomModel RoomModel { get; init; }
    }
}