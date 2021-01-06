using System.Threading.Tasks;

using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;

namespace Api.Hotel.Rooms
{
    public interface IRoomManager
    {
        ValueTask<IRoom?> LoadRoomAsync(uint roomId);
    }
}
