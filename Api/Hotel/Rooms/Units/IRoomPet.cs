
using Api.Hotel.Habbos;
using Api.Util.Interfaces;

namespace Api.Hotel.Rooms.Units
{
    public interface IRoomPet : IPacketSerializable
    {
        public IHabboProfile Owner { get; }
    }
}