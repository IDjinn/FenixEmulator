using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Util.Interfaces;

namespace Server.Hotel.Rooms.Units.Pets
{
    internal interface IRoomPet : IPacketSerializable
    {
        public IHabboProfile Owner { get; }
    }
}