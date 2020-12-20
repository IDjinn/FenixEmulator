using Fenix.Hotel.Habbos;
using Fenix.Hotel.Rooms.Units.Util;
using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units.Users
{
    record RoomUser : RoomUnit, IRoomUser
    {
        public IHabbo Habbo { get; init; }
        public override string Name { get => Habbo.HabboProfile.Username; }
        public byte DanceId { get; private set; }

        public bool IsDancing { get => DanceId > 0; }

        public long IdleTimestamp { get; private set; }

        public bool IsIdle => IdleTimestamp > DateTime.Now.Ticks;

        public RoomUser(IHabbo habbo, IRoom room, string name) : base(room, name) {
            Habbo = habbo;
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

        public IOutgoingPacket Serializable()
        {
            return new OutgoingPacket(0)
                .WriteUInt(Habbo.HabboProfile.Id)
                .WriteString(Name)
                .WriteString("motto")
                .WriteString("look")
                .WriteUInt(Id)
                .WriteInt(0)// x
                .WriteInt(0)// y
                .WriteString(0 + "")// z
                .WriteByte(BodyDirection)
                .WriteInt(1)
                .WriteString("GENDER")
                .WriteInt(-1)// Group id
                .WriteInt(1) // Group any
                .WriteString("group name")
                .WriteString("")
                .WriteInt(0) // Achievement Score
                .WriteBoolean(true);
        }
    }
}
