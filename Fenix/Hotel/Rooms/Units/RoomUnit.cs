using Fenix.Hotel.Rooms.Floor;
using Fenix.Networking.Messages.Outgoing;
using Fenix.Util.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms.Units
{
    record RoomUnit : IRoomUnit
    {
        private static readonly object locker = new object();

        public ushort Id { get; init; }
        public virtual string Name { get; protected init; }
        public virtual string? Motto { get; protected set; }
        public virtual string Look { get; protected set; }
        public IRoom Room { get; init; }
        public ushort X { get; private set; }
        public ushort Y { get; private set; }
        public float Z { get; private set; }
        public IRoomTile RoomTile { get; private set; }

        private bool updateNeeded;
        public bool UpdateNeeded
        {
            get => updateNeeded;
            set
            {
                lock (locker)
                {
                    updateNeeded = value;
                }
            }
        }

        public Direction LastBodyDirection { get; private set; }
        public Direction LastHeadDirection { get; private set; }
        private Direction bodyDirection;
        private Direction headDirection;

        public Direction BodyDirection
        {
            get => bodyDirection;
            set
            {
                LastBodyDirection = bodyDirection;
                bodyDirection = value;
            }
        }
        public Direction HeadDirection
        {
            get => headDirection;
            set
            {
                LastHeadDirection = headDirection;
                headDirection = value;
            }
        }

        public RoomUnit() { }

        public RoomUnit(IRoom room, string name) => (Room, Name) = (room, name);

        public void SetUpdateNeed(bool value)
        {
            UpdateNeeded = value;
        }

        protected virtual void SetRoomTile(IRoomTile tile)
        {
            RoomTile = tile ?? throw new ArgumentNullException(nameof(tile), "Tile must be IRoomTile");
        }

        protected virtual IOutgoingPacket Serializable(IOutgoingPacket? packet = null)
        {
            return null; 
        }
    }
}
