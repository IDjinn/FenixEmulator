using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;

using Api.Hotel.Rooms.Floor;
using Api.Util.Enums;

namespace Server.Hotel.Rooms.Floor
{
    [Table("Room_Models")]
    public class RoomModel : IRoomModel
    {
        [Key]
        public string Name { get; init; }
        public ushort DoorX { get; init; }
        public ushort DoorY { get; init; }
        public ushort DoorZ { get; init; }
        public Direction DoorDirection { get; init; }
        public string? FloorHeigthMap { get; init; }
        [NotMapped]
        public ReadOnlyDictionary<Point, IRoomTile> FloorMap { get; private set; }

        public RoomModel()
        {
            FloorMap = new ReadOnlyDictionary<Point, IRoomTile>(ParseFloorMap(FloorHeigthMap));
        }

        private static Dictionary<Point, IRoomTile> ParseFloorMap(string floorHeigthMap)
        {
            var dict = new Dictionary<Point, IRoomTile>();
            string[] lines = floorHeigthMap.ToLower().Replace('\r', Convert.ToChar(13)).Split('\n');
            for (ushort i = 0; i < lines.Length; i++)
            {
                for (ushort j = 0; j < floorHeigthMap.Length; j++)
                {
                    if (j >= lines.Length)
                        break;

                    char[] line = lines[j].ToArray();
                    var point = new Point(j, i);
                    var state = line[i] is 'x' ? FloorState.BLOCKED : FloorState.OPEN;
                    var tile = new RoomTile(j, i, ParseFloorHeight(line[i]), state);
                    dict.Add(point, tile);
                }
            }

            return dict;
        }

        public IRoomTile? GetRoomTile(Point point)
        {
            return FloorMap.GetValueOrDefault(point);
        }

        public IRoomTile[] GetRoomTiles(Point[] points)
        {
            var list = new List<IRoomTile>();
            for (int i = 0; i < points.Length; i++)
            {
                var roomTile = GetRoomTile(points[i]);
                if (roomTile is IRoomTile tile)
                    list.Add(tile);
            }

            return list.ToArray();
        }

        public static byte ParseFloorHeight(char floor)
        {
            return floor switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                'a' => 10,
                'b' => 11,
                'c' => 12,
                'd' => 13,
                'e' => 14,
                'f' => 15,
                'g' => 16,
                'h' => 17,
                'i' => 18,
                'j' => 19,
                'k' => 20,
                'l' => 21,
                'm' => 22,
                'n' => 23,
                'o' => 24,
                'p' => 25,
                'q' => 26,
                'r' => 27,
                's' => 28,
                't' => 29,
                'u' => 30,
                'v' => 31,
                'w' => 32,
                'x' => byte.MaxValue,
                _ => throw new FormatException("The input was not in a correct format: input must be between (0-x)"),
            };
        }
    }
}
