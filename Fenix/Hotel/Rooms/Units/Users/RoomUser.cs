using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Api.Networking.Messages.Outgoing;
using Server.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms.Units.Users
{
    record RoomUser : RoomUnit, IRoomUser
    {
        public IHabbo Habbo { get; init; }
        public override string Name { get => Habbo.HabboProfile.Username; }
        public override string? Motto { get => Habbo.HabboProfile.Motto; }
        public override string Look { get => Habbo.HabboProfile.Look; }
        public byte DanceId { get; private set; }

        public bool IsDancing { get => DanceId > 0; }

        public long IdleTimestamp { get; private set; }

        public bool IsIdle => IdleTimestamp > DateTime.Now.Ticks;
        public RoomUser() : base()
        {

        }

        public RoomUser(IHabbo habbo, IRoom room, string name) : base(room, name)
        {
            Habbo = habbo;
        }

        public RoomUser(IHabbo habbo, IRoom room) : base(room, "")
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
