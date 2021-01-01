using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Api.Networking.Messages.Outgoing;
using Server.Networking.Messages.Outgoing;
using System;

namespace Server.Hotel.Rooms.Units.Bots
{
    record RoomBot : RoomUnit, IRoomBot
    {
        public IHabboProfile Owner { get; private set; }
        public Char Gender { get; init; }

        public byte DanceId { get; private set; }

        public bool IsDancing => DanceId > 0;

        public long IdleTimestamp { get; private set; }

        public bool IsIdle => DateTime.Now.Ticks > IdleTimestamp;

        public RoomBot(IRoom room, string name) : base(room, name) { }

        public RoomBot(IRoom room, IHabboProfile owner) : base(room, "") => Owner = owner;

        public void StartDance(byte danceId)
        {
            DanceId = danceId;
        }

        public void StopDance()
        {
            DanceId = 0;
        }

        public void StartIdle(long value)
        {
            IdleTimestamp = DateTime.Now.Ticks + value;
        }

        public void StopIdle()
        {
            IdleTimestamp = 0;
        }

        public IOutgoingPacket Serializable(IOutgoingPacket? packet = null)
        {
            return new OutgoingPacket(0)
                .Write((uint)Id)
                .Write(base.Name)
                .Write(Motto ?? $"My owner is {Owner.Username}")
                .Write(Look)
                .Write((uint)Id)
                .Write(X) // X
                .Write(Y) // Y
                .Write(Z + "") // Z
                .Write((byte)BodyDirection)
                .Write(4)
                .Write(Gender)
                .Write(Owner.Id)
                .Write(Owner.Username ?? "Unknown")
                .Write(10)
                // shorts
                .Write(0)
                .Write(1)
                .Write(2)
                .Write(3)
                .Write(4)
                .Write(5)
                .Write(6)
                .Write(7)
                .Write(8)
                .Write(9);
        }
    }
}
