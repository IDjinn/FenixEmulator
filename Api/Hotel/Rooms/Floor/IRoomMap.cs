using Api.Hotel.Items;
using System.Drawing;

namespace Api.Hotel.Rooms.Floor
{
    public interface IRoomMap
    {
        public IRoom Room { get; init; }
        public IRoomModel RoomModel { get; init; }

        public bool TryAddItemToMap(Point point, IItem item);
        public bool TryRemoveItemFromMap(Point point, IItem item);
        public bool TryAddUnitToMap(Point point, IRoomUnit roomUnit);
        public bool TryRemoveUnitFromMap(Point point, IRoomUnit roomUnit);
    }
}