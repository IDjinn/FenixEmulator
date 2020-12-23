using Fenix.Hotel.Rooms.Floor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms
{
    public interface IRoomManager
    {
        ValueTask<IRoom?> LoadRoom(uint roomId);
        ValueTask<IRoomModel?> GetRoomModel(string modelName);
    }
}
