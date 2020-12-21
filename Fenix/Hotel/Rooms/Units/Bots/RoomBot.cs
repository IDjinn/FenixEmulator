using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Rooms.Units.Util;
using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units.Bots
{
    record RoomBot : RoomUnit, IRoomBot
    {
        public IHabboProfile Owner { get; private set; }
        public byte DanceId { get; private set; }

        public bool IsDancing => DanceId > 0;

        public long IdleTimestamp { get; private set; }

        public bool IsIdle => DateTime.Now.Ticks > IdleTimestamp;

        public RoomBot(IRoom room, string name) : base(room, name) { }

        public RoomBot(IRoom room, IHabbo owner) : base(room) => Owner = owner;

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
                .WriteUInt(Id)
                .WriteString(Name)
                .WriteString("Notto")
                .WriteString("Figure")
                .WriteUInt(Id)
                .WriteInt(0) // X
                .WriteInt(0) // Y
                .WriteString(0 + "") // Z
                .WriteByte(BodyDirection)
                .WriteInt(4)
                .WriteString("Gender")
                .WriteInt(OwnerId)
                .WriteString(Owner?.HabboProfile.Username ?? "Unknown")
                .WriteInt(10)
                // shorts
                .WriteInt(0)
                .WriteInt(1)
                .WriteInt(2)
                .WriteInt(3)
                .WriteInt(4)
                .WriteInt(5)
                .WriteInt(6)
                .WriteInt(7)
                .WriteInt(8)
                .WriteInt(9);
        }
    }
}
