using System;

using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Floor;
using Api.Networking.Messages.Outgoing;
using Api.Util.Enums;

namespace Server.Hotel.Rooms.Units
{
    public record RoomUnit : IRoomUnit
    {
        private static readonly object locker = new object();

        public ushort Id { get; protected init; }
        public string Name { get; private set; }
        public string? Motto { get; private set; }
        public string Look { get; private set; }
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

        public RoomUnit(IRoom room) => (Room) = (room);

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

        protected void SetName(string Name)
        {
            this.Name = Name;
        }

        protected void SetMotto(string Motto)
        {
            this.Motto = Motto;
        }

        protected void SetLook(string Look)
        {
            this.Look = Look;
        }
    }
}
