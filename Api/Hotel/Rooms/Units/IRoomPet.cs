﻿using Api.Hotel.Habbos.Profile;
using Api.Util.Interfaces;

namespace Api.Hotel.Rooms.Units
{
    public interface IRoomPet : IPacketSerializable, IRoomUnit
    {
        public IHabboProfile Owner { get; }
    }
}