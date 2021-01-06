using System;

using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Api.Networking.Messages.Outgoing;

using Server.Networking.Messages.Outgoing;

namespace Server.Hotel.Rooms.Units.Users
{
    public record RoomUser : RoomUnit, IRoomUser
    {
        public IHabbo Habbo { get; init; }
        public byte DanceId { get; private set; }

        public bool IsDancing { get => DanceId > 0; }

        public long IdleTimestamp { get; private set; }

        public bool IsIdle => IdleTimestamp > DateTime.Now.Ticks;
        public RoomUser(ushort Id, IRoom room) : base(room)
        {
            this.Id = Id;
        }

        public RoomUser(ushort id, IHabbo habbo, IRoom room, string name, string motto, string look) : base(room) 
        {
            Id = id;
            Habbo = habbo;

            SetName(name);
            SetMotto(motto);
            SetLook(look);
        }

        public RoomUser(IHabbo habbo, IRoom room) : base(room)
        {
            Habbo = habbo;
        }

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
            packet ??= new OutgoingPacket(OutgoingPacketsHeader.RoomUsersComposer).Write((int)1);
            return packet.Write(Habbo.HabboProfile.Id)
             .Write(Name)
             .Write(Habbo.HabboProfile.Motto ?? "")
             .Write(Habbo.HabboProfile.Look)
             .Write(Id)
             .Write(X)
             .Write(Y)
             .Write(Z + "")
             .Write((byte)BodyDirection)
             .Write(1)
             .Write(Habbo.HabboProfile.Gender)
             .Write(-1) // Group id
             .Write(1) // Group any
             .Write("group name")
             .Write("")
             .Write(0) // Achievement Score
             .Write(true);
        }
    }
}
