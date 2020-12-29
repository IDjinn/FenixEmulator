using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Factories.Interfaces
{
    public interface IRoomFactory
    {
        IRoom Create(IRoomInfo roomInfo);
    }
}
