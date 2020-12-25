using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public IHabboProfile Owner { get; init; }
        public DoorAcessType DoorAcess { get; init; }
        public string? Password { get; init; }
        public ushort Rating { get; init; }

        public IOutgoingPacket Serializable(IOutgoingPacket? packet = null)
        {
            return new OutgoingPacket(0)
                .Write(Id)
                .Write(Name)
                .Write(Owner.Id)
                .Write(Owner.Username ?? "Unknown")
                .Write((byte)DoorAcess)
                .Write((uint)20) // users now
                .Write((uint)200) // users max
                .Write(Description ?? "")
                .Write((uint)1) // trade settings
                .Write((uint)Rating)
                .Write((uint)0) // top rated room rank
                .Write((uint)Category)

                .Write(0);// tags
        }
    }
}
