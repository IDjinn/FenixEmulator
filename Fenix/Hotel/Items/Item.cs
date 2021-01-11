using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

using Api.Hotel.Habbos.Profile;
using Api.Hotel.Items;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;

using Server.Hotel.Habbos.Profile;
using Server.Hotel.Rooms.Info;

namespace Server.Hotel.Items
{
    public class Item : IItem
    {
        protected readonly object locker = new object();

        public ulong Id { get; init; }
        public uint OwnerId { get; init; }
        public uint? RoomInfoId { get; init; }
        public uint ItemDataId { get; init; }
        public ItemData ItemData { get; set; }

        public virtual HabboProfile? Owner { get; set; }
        public virtual RoomInfo? RoomInfo { get; set; }
        [NotMapped]
        public IRoom? Room { get; private set; }
        [NotMapped]
        private bool updateNeeded;
        [NotMapped]
        public bool InRoom => Room is IRoom;
        [NotMapped]
        public bool UpdateNeeded
        {
            get => updateNeeded;
            set
            {
                lock (locker) updateNeeded = value;
            }
        }

        public virtual ValueTask Update(params object[] args)
        {
            return default;
        }

    }
}
