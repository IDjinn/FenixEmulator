namespace Fenix.Hotel.Rooms.Floor
{
    public interface IRoomTile
    {
        public ushort X { get; init; }
        public ushort Y { get; init; }
        public ushort Z { get; init; }
        public FloorState State { get; }
        public float GScore { get; set; }
        public float FScore { get; set; }
    }
}