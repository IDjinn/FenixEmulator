
using Api.Hotel.Habbos;
using Api.Hotel.Rooms.Units.Utils;
using Api.Util.Interfaces;

namespace Api.Hotel.Rooms.Units
{
    public interface IRoomUser : IUnitDanceable, IUnitIdleable, IPacketSerializable
    {
        public IHabbo Habbo { get; init; }
    }
}