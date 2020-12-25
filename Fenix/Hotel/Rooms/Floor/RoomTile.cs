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
    public record RoomTile : IRoomTile
    {
        public ushort X { get; init; }
        public ushort Y { get; init; }
        public ushort Z { get; init; }
        public float GScore { get; set; }
        public float FScore { get; set; }
        public IRoomTile? Parent { get; set; }
        public FloorState FloorState { get; set; }
        public Point ToPoint => new Point(X, Y);

        public RoomTile(ushort x, ushort y, ushort z, FloorState state)
        {
            X = x;
            Y = y;
            Z = z;
            FloorState = state;
        }
    }
}
