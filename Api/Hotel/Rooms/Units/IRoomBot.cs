using Api.Hotel.Habbos;
using Api.Hotel.Rooms.Units.Utils;
using Api.Util.Interfaces;
using System;

namespace Api.Hotel.Rooms.Units
{
    internal interface IRoomBot : IUnitDanceable, IUnitIdleable, IPacketSerializable
    {
        public IHabboProfile Owner { get; }
        public Char Gender { get; }
    }
}