﻿using Fenix.Hotel.Habbos;
using Fenix.Util.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fenix.Hotel.Rooms.Info
{
    public interface IRoomInfo : IPacketSerializable
    {
        public uint Id { get; init; }
        public string Name { get; init; }
        public byte Category { get; init; }
        public string? Description { get; init; }
        public ushort OwnerId { get; init; }
        [NotMapped]
        public IHabbo? Owner { get; init; }
        public DoorAcessType DoorAcess { get; init; }
        public string? Password { get; init; }
        public ushort Rating { get; init; }
    }
}