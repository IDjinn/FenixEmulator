using Fenix.Hotel.Habbos;
using Fenix.Hotel.Rooms.Units.Util;
using Fenix.Util.Interfaces;

namespace Fenix.Hotel.Rooms.Units.Bots
{
    internal interface IRoomBot : IUnitDanceable, IUnitIdleable, IPacketSerializable
    {
        public ushort OwnerId { get; init; }
        public IHabbo? Owner { get; }
    }
}