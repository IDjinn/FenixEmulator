using Fenix.Hotel.Habbos;
using Fenix.Util.Interfaces;

namespace Fenix.Hotel.Rooms.Units.Pets
{
    internal interface IRoomPet : IPacketSerializable
    {
        public ushort OwnerId { get; init; }
        public IHabbo? Owner { get; }
    }
}