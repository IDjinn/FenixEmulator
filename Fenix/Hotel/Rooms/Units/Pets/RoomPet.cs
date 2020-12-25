using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Rooms.Units.Util;
using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units.Pets
{
    record RoomPet : RoomUnit, IRoomPet
    { 
        public IHabboProfile Owner { get; private set; }

        public RoomPet(IRoom room, string name) : base(room, name) { }

        public RoomPet(RoomUnit roomUnit) : base(roomUnit) { }
        public RoomPet(RoomUnit roomUnit, IHabboProfile owner) : base(roomUnit) => Owner = owner;

        public IOutgoingPacket Serializable(IOutgoingPacket? packet = null)
        {
            return new OutgoingPacket(0)
                .Write((uint)Id)
                .Write(base.Motto ?? $"My owner is {Owner.Username}")
                .Write(base.Look)
                .Write(0)// x
                .Write(0)// y
                .Write(0 + "")// z
                .Write(0)
                .Write(2)
                .Write(200) // pet type
                .Write(Owner.Id)
                .Write(Owner.Username ?? "unknown")
                .Write(false) // sela
                .Write(false)
                .Write(false) // can breed
                .Write(false) // planta monstro crescida
                .Write(false) // planta monstro morta
                .Write(false) // public breedable
                .Write(0) //level
                .Write("");
        }
    }
}
