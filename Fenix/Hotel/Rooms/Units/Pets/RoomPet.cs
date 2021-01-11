using Api.Hotel.Habbos.Profile;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Api.Networking.Messages.Outgoing;

using Server.Networking.Messages.Outgoing;

namespace Server.Hotel.Rooms.Units.Pets
{
    record RoomPet : RoomUnit, IRoomPet
    {
        public IHabboProfile Owner { get; private set; }

        public RoomPet(IRoom room) : base(room) { }

        public RoomPet(IRoom room, IHabboProfile owner) : base(room) => Owner = owner;

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
