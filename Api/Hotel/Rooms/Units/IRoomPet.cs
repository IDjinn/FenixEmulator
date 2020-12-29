
using Api.Hotel.Habbos;
using Api.Util.Interfaces;

namespace Api.Hotel.Rooms.Units
{
    internal interface IRoomPet : IPacketSerializable
    {
        public IHabboProfile Owner { get; }
    }
}