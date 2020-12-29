using Fenix.Hotel.Rooms.Floor;
using Fenix.Hotel.Rooms.Info;
using Fenix.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms
{
    public interface IRoom
    {
        public uint Id { get; init; }
        public IRoomInfo RoomInfo { get; init; }
        public IRoomModel RoomModel { get; init; }

    }
}
