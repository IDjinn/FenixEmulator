namespace Api.Hotel.Items
{
    public interface IItemDTO
    {
        public ulong Id { get; init; }
        public uint OwnerId { get; init; }
        public ushort ItemDataId { get; init; }
        public uint? RoomInfoId { get; init; }
    }
}
