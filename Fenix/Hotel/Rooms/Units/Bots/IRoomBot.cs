using Api.Hotel.Habbos;
using Api.Hotel.Habbos.Profile;
using Api.Hotel.Rooms.Units.Util;
using Api.Util.Interfaces;
using System;

namespace Server.Hotel.Rooms.Units.Bots
{
    internal interface IRoomBot : IUnitDanceable, IUnitIdleable, IPacketSerializable
    {
        public IHabboProfile Owner { get; }
        public Char Gender { get; }
    }
}