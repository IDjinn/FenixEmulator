using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms
{
    interface IRoomManager
    {
        ValueTask<IRoom> LoadRoom(uint roomId);
    }
}
