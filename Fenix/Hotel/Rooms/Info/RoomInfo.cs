using Fenix.Hotel.Habbos;
using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Info
{
    class RoomInfo : IRoomInfo
    {
        public uint Id { get; init; }
        public string Name { get; init; }
        public byte Category { get; init; }
        public string? Description { get; init; }
        public ushort OwnerId { get; init; }
        public IHabbo? Owner { get; init; }
        public DoorAcessType DoorAcess { get; init; }
        public string? Password { get; init; }
        public ushort Rating { get; init; }

        public IOutgoingPacket Serializable()
        {
            return new OutgoingPacket(0)
                .WriteUInt(Id)
                .WriteString(Name)
                .WriteUInt(OwnerId)
                .WriteString(Owner?.HabboProfile.Username ?? "Unknown")
                .WriteByte((byte)DoorAcess)
                .WriteUInt(20) // users now
                .WriteUInt(200) // users max
                .WriteString(Description ?? "")
                .WriteUInt(1) // trade settings
                .WriteUInt(Rating)
                .WriteUInt(0) // top rated room rank
                .WriteUInt(Category)

                .WriteInt(0);// tags
        }
    }
}
