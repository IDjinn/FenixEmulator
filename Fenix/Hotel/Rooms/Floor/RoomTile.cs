using Fenix.Hotel.Items;
using Fenix.Hotel.Rooms.Units;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Floor
{
    [NotMapped]
    class RoomTile : IRoomTile
    {
        public ushort X { get; init; }
        public ushort Y { get; init; }
        public ushort Z { get; init; }
        public FloorState State { get; private set; }

        private ConcurrentDictionary<ushort, IRoomUnit> tileUnits { get; init; }

        public RoomTile(ushort x, ushort y, ushort z, FloorState state = FloorState.OPEN)
        {
            X = x;
            Y = y;
            Z = z;
            State = state;

            tileUnits = new ConcurrentDictionary<ushort, IRoomUnit>();
        }
    }
}
