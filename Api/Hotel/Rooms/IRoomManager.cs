using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotel.Rooms
{
    public interface IRoomManager
    {
        ValueTask<IRoom?> LoadRoomAsync(uint roomId);
        ValueTask<IRoomModel?> GetRoomModelAsync(string modelName);
        ValueTask<IRoomInfo?> GetRoomInfoAsync(uint roomId);
    }
}
