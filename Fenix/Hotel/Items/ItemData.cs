using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Items
{
    public record ItemData : IItemData
    {
        public uint Id { get; init; }
        public uint SpriteId { get; init; }
        public string FurniLine { get; init; }
        public string PublicName { get; init; }
        public string ItemName { get; init; }
        public Char Type { get; init; }
        public byte Width { get; init; }
        public byte Length { get; init; }
        public double StackHeigth { get; init; }
        public bool AllowStack { get; init; }
        public bool AllowSit { get; init; }
        public bool AllowLay { get; init; }
        public bool AllowWalk { get; init; }
        public bool AllowGift { get; init; }
        public bool AllowTrade { get; init; }
        public bool AllowRecycle { get; init; }
        public bool AllowMarketplaceSell { get; init; }
        public bool AllowInventoryStack { get; init; }
        public String InteractionType { get; init; }
        public byte InteractionModesCount { get; init; }
        public String? VendingIds { get; init; }
        public String? MultiHeight { get; init; }
        public String? CustomParams { get; init; }
        public byte EffectIdMale { get; init; }
        public byte EffectIdFemale { get; init; }
        public String? ClothingOnWalk { get; init; }

        public ItemData() { }
    }
}
