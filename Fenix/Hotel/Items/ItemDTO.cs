using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Hotel.Items;

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
