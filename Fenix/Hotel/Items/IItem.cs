using Fenix.Hotel.Habbos;
using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Rooms;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Fenix.Hotel.Items
{
    internal interface IItem
    {
        public IItemData ItemData { get; init; }
        public IHabboProfile Owner { get; init; }
        public ushort? RoomId { get; init; }
        public IRoom? Room { get; init; }


        public bool InRoom { get; }
        public bool UpdateNeeded { get; set; }

        public abstract ValueTask Update(params object[] args);
    }
}