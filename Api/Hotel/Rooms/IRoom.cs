using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotel.Rooms
{
    public interface IRoom
    {
        public uint Id { get; init; }
        public IRoomInfo RoomInfo { get; init; }
        public IRoomModel RoomModel { get; init; }
    }
}
