using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

using Api.Hotel.Habbos;
using Api.Hotel.Items;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;

namespace Server.Hotel.Items
{
    public abstract class Item : IItem
    {
        protected readonly object locker = new object();

        public ushort Id { get; init; }
        public IItemData ItemData { get; init; }
        public IHabboProfile Owner { get; init; }
        public IRoomInfo? RoomInfo { get; init; }

        [NotMapped]
        public IRoom? Room { get; init; }
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

        public abstract ValueTask Update(params object[] args);
    }
}
