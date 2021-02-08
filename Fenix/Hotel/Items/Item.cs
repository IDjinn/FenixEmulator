using Api.Hotel.Habbos.Profile;
using Api.Hotel.Items;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Server.Hotel.Items
{
    [Table("items")]
    public class Item : IItem
    {
        protected readonly object locker = new object();

        public ulong Id { get; init; }
        public uint OwnerId { get; init; }
        public ushort ItemDataId { get; init; }
        public uint? RoomInfoId { get; init; }


        public IHabboProfile? Owner { get; private set; }
        public IItemData? ItemData { get; private set; }
        public IRoomInfo? RoomInfo { get; private set; }

        public IRoom? Room { get; private set; }
        private bool updateNeeded;
        public bool InRoom => Room is IRoom;
        public bool UpdateNeeded
        {
            get => updateNeeded;
            set
            {
                lock (locker) updateNeeded = value;
            }
        }

        public Item(IItemDTO itemDTO, IItemData itemData, IHabboProfile owner)
        {
            Id = itemDTO.Id;
            ItemDataId = itemDTO.ItemDataId;
            OwnerId = itemDTO.OwnerId;
            RoomInfoId = itemDTO.RoomInfoId;
            ItemData = itemData;
            Owner = owner;
        }

        public Item(IItemDTO itemDTO, IItemData itemData, IHabboProfile owner, IRoomInfo? roomInfo) : this(itemDTO, itemData, owner)
        {
            RoomInfo = roomInfo;
        }


        public virtual ValueTask Update(params object[] args)
        {
            return default;
        }


        public void SetOwner(IHabboProfile? owner)
        {
            Owner = owner;
        }

        public void SetItemData(IItemData? itemData)
        {
            ItemData = itemData;
        }

        public void SetRoomInfo(IRoomInfo? roomInfo)
        {
            RoomInfo = roomInfo;
        }
    }
}
