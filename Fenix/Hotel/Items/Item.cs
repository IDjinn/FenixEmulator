using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Items
{
    public abstract class Item : IItem
    {
        private static readonly object locker = new object();

        public ushort Id { get; init; }
        public IItemData ItemData { get; init; }
        public IHabboProfile Owner { get; init; }
        public ushort? RoomId { get; init; }
        [NotMapped]
        public IRoom? Room { get; init; }

        private bool updateNeeded;

        public bool InRoom => RoomId is not null && Room is IRoom;
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
