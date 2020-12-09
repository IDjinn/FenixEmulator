using Api.Util.Interfaces;

namespace Api.Hotel.Rooms.Info
{
    public interface IRoomInfo : IPacketSerializable
    {
        public uint Id { get; init; }
        public string Name { get; init; }
        public byte Category { get; init; }
        public string? Description { get; init; }
        public uint OwnerId { get; init; }
        //public IHabboProfile? Owner { get; }
        public DoorAcessType DoorAcess { get; init; }
        public string? Password { get; init; }
        public ushort Rating { get; init; }


    }
}