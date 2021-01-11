using System;

using Api.Hotel.Habbos.Profile;
using Api.Hotel.Rooms.Units.Utils;
using Api.Util.Interfaces;

namespace Api.Hotel.Rooms.Units
{
    public interface IRoomBot : IUnitDanceable, IUnitIdleable, IPacketSerializable, IRoomUnit
    {
        public IHabboProfile Owner { get; }
        public Char Gender { get; }
    }
}