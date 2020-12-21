using Fenix.Hotel.Items;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Floor
{
    class RoomMap : IRoomMap
    {
        public IRoom Room { get; init; }
        public IRoomModel RoomModel { get; init; }
        private ConcurrentDictionary<Point, IItem> floorItems { get; init; }

        public RoomMap(IRoom room, IRoomModel roomModel)
        {
            Room = room;
            RoomModel = roomModel;
            floorItems = new ConcurrentDictionary<Point, IItem>();
        }
    }
}
