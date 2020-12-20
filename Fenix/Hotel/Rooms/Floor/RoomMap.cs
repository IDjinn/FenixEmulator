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
        private ConcurrentDictionary<Point, FloorState> floorState { get; init; }

        public RoomMap(IRoom room, IRoomModel roomModel)
        {
            Room = room;
            RoomModel = roomModel;
            floorState = new ConcurrentDictionary<Point, FloorState>();

            var floorPoints = roomModel.FloorMap.Keys.ToArray();
            for (int i = 0; i < floorPoints.Length; i++)
            {
                var point = floorPoints[i];
                var heigth = RoomModel.FloorMap[point]; // TODO: Refractor this for
                floorState[point] = FloorStateFromHeigth(heigth);
            }
        }

        public FloorState? TryGetFloorStateAt(Point point)
        {
            if (floorState.TryGetValue(point, out FloorState state))
                return state;

            return null;
        }

        public static FloorState FloorStateFromHeigth(byte heigth)
        {
            return heigth switch
            {
                byte.MaxValue => FloorState.BLOCKED,
                _ => FloorState.OPEN
            };
        }

    }
}
