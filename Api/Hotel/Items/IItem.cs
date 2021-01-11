using System.Threading.Tasks;

using Api.Hotel.Habbos.Profile;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;

namespace Api.Hotel.Items
{
    public interface IItem
    {
        public ulong Id { get; init; }
        public uint OwnerId { get; init; }
        public uint? RoomInfoId { get; init; }
       // public uint ItemDataId { get; init; }

        //public IHabboProfile? Owner { get; set; }
        //public IRoomInfo? RoomInfo { get; set; }
        public IRoom? Room { get; }
        public bool InRoom => Room is IRoom;

        public ValueTask Update(params object[] args);
    }
}