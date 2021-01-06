using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

using Api.Hotel.Items;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Floor;

namespace Server.Hotel.Rooms.Floor
{
    [NotMapped]
    public class RoomMap : IRoomMap
    {
        public IRoom Room { get; init; }
        public IRoomModel RoomModel { get; init; }

        private ConcurrentDictionary<Point, IList<IItem>> floorItems { get; init; }
        private ConcurrentDictionary<Point, IList<IRoomUnit>> tileUnits { get; init; }

        public RoomMap(IRoom room, IRoomModel roomModel)
        {
            Room = room;
            RoomModel = roomModel;

            floorItems = new ConcurrentDictionary<Point, IList<IItem>>();
            tileUnits = new ConcurrentDictionary<Point, IList<IRoomUnit>>();
        }

        public bool TryAddItemToMap(Point point, IItem item)
        {
            if (floorItems.TryGetValue(point, out IList<IItem>? items))
            {
                items.Add(item);
                return true;
            }

            items ??= new List<IItem>()
            {
                item
            };

            return floorItems.TryAdd(point, items);
        }

        public bool TryRemoveItemFromMap(Point point, IItem item)
        {
            if (floorItems.TryGetValue(point, out IList<IItem>? items))
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Id == item.Id)
                        items.RemoveAt(i);
                }
            }
            return true;
        }

        public bool TryAddUnitToMap(Point point, IRoomUnit roomUnit)
        {
            if (tileUnits.TryGetValue(point, out IList<IRoomUnit>? units))
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
            if (tileUnits.TryGetValue(point, out IList<IRoomUnit>? units))
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
