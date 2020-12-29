using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Api.Hotel.Items
{
    public interface IItem
    {
        public ushort Id { get; init; }
        public IItemData ItemData { get; init; }
        public IHabboProfile Owner { get; init; }
        public IRoomInfo? RoomInfo { get; init; }
        public IRoom? Room { get; init; }


        public bool InRoom => Room is IRoom;

        public abstract ValueTask Update(params object[] args);
    }
}