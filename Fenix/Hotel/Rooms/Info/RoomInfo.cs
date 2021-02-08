using Api.Hotel.Rooms.Info;
using Api.Networking.Messages.Outgoing;
using Server.Hotel.Habbos.Profile;
using Server.Networking.Messages.Outgoing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Hotel.Rooms.Info
{
    [Table("rooms_info")]
    public record RoomInfo : IRoomInfo
    {
        public uint Id { get; init; }
        public string Name { get; init; }
        public byte Category { get; init; }
        public string? Description { get; init; }
        public uint OwnerId { get; init; }
        public DoorAcessType DoorAcess { get; init; }
        public string? Password { get; init; }
        public ushort Rating { get; init; }

        public virtual HabboProfile? Owner { get; set; }

        public IOutgoingPacket Serializable(IOutgoingPacket? packet = null)
        {
            return new OutgoingPacket(0)
                .Write(Id)
                .Write(Name)
                .Write(Owner?.Id ?? 0)
                .Write(Owner?.Username ?? "Unknown")
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
