using Api.Util.Interfaces;
using System.Threading.Tasks;

namespace Api.Hotel.Rooms
{
    public interface IRoomManager
    {
        ValueTask<IRoom?> LoadRoomAsync(uint roomId);
    }
}
