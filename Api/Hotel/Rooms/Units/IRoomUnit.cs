using Api.Hotel.Rooms.Floor;
using Api.Util.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotel.Rooms
{
    public interface IRoomUnit
    {
        public ushort Id { get; init; }
        public string Name { get; }
        public string? Motto { get; }
        public string Look { get; }
        public IRoom Room { get; }
        public ushort X { get; }
        public ushort Y { get; }
        public float Z { get; }
        public IRoomTile RoomTile { get; }
        public Direction BodyDirection { get; }
        public Direction HeadDirection { get; }
        public Direction LastBodyDirection { get; }
        public Direction LastHeadDirection { get; }
    }
}
