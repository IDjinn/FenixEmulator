using Api.Hotel.Items;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Hotel.Items
{
    [Table("items")]
    public record ItemDTO : IItemDTO
    {
        public ulong Id { get; init; }
        public uint OwnerId { get; init; }
        public ushort ItemDataId { get; init; }
        public uint? RoomInfoId { get; init; }
    }
}
