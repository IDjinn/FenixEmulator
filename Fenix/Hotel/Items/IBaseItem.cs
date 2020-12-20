using Fenix.Hotel.Items.Util;
using System;

namespace Fenix.Hotel.Items
{
    internal interface IBaseItem
    {
        public ushort Id { get; init; }
        public ushort SpriteId { get; init; }
        public string ItemName { get; init; }
        public string PublicName { get; init; }
        public String Type { get; init; }
        public int Width { get; init; }
        public int Length { get; init; }
        public double Height { get; init; }
        public bool Stackable { get; init; }
        public bool Walkable { get; init; }
        public bool IsSeat { get; init; }
        public bool AllowEcotronRecycle { get; init; }
        public bool AllowTrade { get; init; }
        public bool AllowMarketplaceSell { get; init; }
        public bool AllowGift { get; init; }
        public bool AllowInventoryStack { get; init; }
        public InteractionType InteractionType { get; init; }
        public int Modes { get; init; }
        public double[] AdjustableHeights { get; init; }
    }
}