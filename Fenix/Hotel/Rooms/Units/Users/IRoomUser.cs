using Fenix.Hotel.Habbos;
using Fenix.Hotel.Rooms.Units.Util;
using Fenix.Util.Interfaces;

namespace Fenix.Hotel.Rooms.Units.Users
{
    public interface IRoomUser : IUnitDanceable, IUnitIdleable, IPacketSerializable
    {
        public IHabbo Habbo { get; init; }
    }
}