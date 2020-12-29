using Api.Hotel.Habbos;
using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Items
{
    public abstract class Item : IItem
    {
        private static readonly object locker = new object();

        public ushort Id { get; init; }
        public IItemData ItemData { get; init; }
        public IHabboProfile Owner { get; init; }
        public IRoomInfo? RoomInfo { get; init; }
        [NotMapped]
        public IRoom? Room { get; init; }

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
