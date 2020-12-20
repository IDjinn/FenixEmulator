using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Fenix.Hotel.Rooms.Floor
{
    public interface IRoomModel
    {
        public string Name { get; init; }
        public ushort DoorX { get; init; }
        public ushort DoorY { get; init; }
        public ushort DoorZ { get; init; }
        [NotMapped]
        public ReadOnlyDictionary<Point, byte> FloorMap { get; init; }
    }
}