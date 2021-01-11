using System.Drawing;

namespace Api.Hotel.Rooms.Floor
{
    public interface IRoomTile
    {
        public ushort X { get; init; }
        public ushort Y { get; init; }
        public ushort Z { get; init; }
        public float GScore { get; set; }
        public float FScore { get; set; }
        public IRoomTile? Parent { get; set; }
        public FloorState FloorState { get; set; }
        public Point ToPoint { get; }
    }
}