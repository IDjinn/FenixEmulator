using Fenix.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units
{
    public interface IRoomUnit
    {
        public uint Id { get; init; }
        public string Name { get; init; }
        public IRoom Room { get; init; }
        /*
        public int X { get; init; }
        public int Y { get; init; }
        public int Z { get; init; }
        */
        public Byte BodyDirection { get; }
        public Byte HeadDirection { get; }
        public Byte LastBodyDirection { get; }
        public Byte LastHeadDirection { get; }
    }
}
