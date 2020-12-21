using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Floor
{
    class RoomModel : IRoomModel
    {
        public string Name { get; init; }
        public ushort DoorX { get; init; }
        public ushort DoorY { get; init; }
        public ushort DoorZ { get; init; }
        public ReadOnlyDictionary<Point, IRoomTile> FloorMap { get; init; }

        public RoomModel()
        {
            Name = string.Empty;
            FloorMap = new ReadOnlyDictionary<Point, IRoomTile>(ParseFloorMap("floormap here"));
        }

        public static Dictionary<Point, IRoomTile> ParseFloorMap(string floorHeigthMap) // TODO: Check these fors
        {
            var dict = new Dictionary<Point, IRoomTile>();
            string[] lines = floorHeigthMap.ToLower().Split('\n');
            for (ushort i = 0; i < lines.Length; i++) 
            {
                for (ushort j = 0; j < floorHeigthMap.Length; j++)
                {
                    var point = new Point(i, j);
                    var state = lines[i][j] == 'x' ? FloorState.BLOCKED : FloorState.OPEN;
                    var tile = new RoomTile(i, j, ParseFloorHeight(lines[i][j]), state);
                    dict.Add(point, tile);
                }
            }

            return dict;
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
