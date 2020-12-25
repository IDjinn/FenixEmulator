using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Rooms.Units.Util;
using Fenix.Util.Interfaces;
using System;

namespace Fenix.Hotel.Rooms.Units.Bots
{
    internal interface IRoomBot : IUnitDanceable, IUnitIdleable, IPacketSerializable
    {
        public IHabboProfile Owner { get; }
        public Char Gender { get; }
    }
}