using Fenix.Hotel.Items;
using Fenix.Hotel.Rooms.Units;
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
        private ConcurrentDictionary<Point, List<IRoomUnit>> tileUnits { get; init; }

        public RoomMap(IRoom room, IRoomModel roomModel)
        {
            Room = room;
            RoomModel = roomModel;

            floorItems = new ConcurrentDictionary<Point, IItem>();
            tileUnits = new ConcurrentDictionary<Point, List<IRoomUnit>>();
        }

        public bool TryAddUnitToMap(Point point, IRoomUnit roomUnit)
        {
            if (tileUnits.TryGetValue(point, out List<IRoomUnit>? units))
            {
                units.Add(roomUnit);
                return true;
            }

            units ??= new List<IRoomUnit>()
            {
                roomUnit
            };

            return tileUnits.TryAdd(point, units);
        }

        public bool TryRemoveUnitFromMap(Point point, IRoomUnit roomUnit)
        {
            if (tileUnits.TryGetValue(point, out List<IRoomUnit>? units))
            {
                for (int i = 0; i < units.Count; i++)
                {
                    if (units[i].Id == roomUnit.Id)
                        units.RemoveAt(i);
                }
            }
            return true;
        }
    }
}
