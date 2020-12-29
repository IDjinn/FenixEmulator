using Fenix.Hotel.Rooms.Floor;
using Fenix.Hotel.Rooms.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms
{
    public interface IRoomManager
    {
        ValueTask<IRoom?> LoadRoomAsync(uint roomId);
        ValueTask<IRoomModel?> GetRoomModelAsync(string modelName);
        ValueTask<IRoomInfo?> GetRoomInfoAsync(uint roomId);
    }
}
