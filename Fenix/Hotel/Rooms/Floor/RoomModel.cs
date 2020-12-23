using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Floor
{
    public class RoomModel : IRoomModel
    {
        public string Name { get; init; }
        public ushort DoorX { get; init; }
        public ushort DoorY { get; init; }
        public ushort DoorZ { get; init; }
        public Byte DoorDirection { get; init; }
        public String FloorHeigthMap { get => ""; init => FloorMap = new ReadOnlyDictionary<Point, IRoomTile>(ParseFloorMap(value)); }
        [NotMapped]
        public ReadOnlyDictionary<Point, IRoomTile> FloorMap { get; private set; }

        private Dictionary<Point, IRoomTile> ParseFloorMap(string floorHeigthMap) 
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
                    var state = line[i] == 'x' ? FloorState.BLOCKED : FloorState.OPEN;
                    var tile = new RoomTile(j,i, ParseFloorHeight(line[i]), state);
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
