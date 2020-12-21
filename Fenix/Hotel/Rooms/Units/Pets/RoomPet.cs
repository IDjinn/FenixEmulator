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

        public IOutgoingPacket Serializable()
        {
            return new OutgoingPacket(0)
                .WriteUInt(Id)
                .WriteString("motto?")
                .WriteString("look")
                .WriteInt(0)// x
                .WriteInt(0)// y
                .WriteString(0 + "")// z
                .WriteInt(0)
                .WriteInt(2)
                .WriteInt(200) // pet type
                .WriteUInt(Owner.Id)
                .WriteString(Owner.Username ?? "unknown")
                .WriteBoolean(false) // sela
                .WriteBoolean(false)
                .WriteBoolean(false) // can breed
                .WriteBoolean(false) // planta monstro crescida
                .WriteBoolean(false) // planta monstro morta
                .WriteBoolean(false) // public breedable
                .WriteInt(0) //level
                .WriteString("");
        }
    }
}
