using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units
{
    record RoomUnit : IRoomUnit
    {
        private static readonly object locker = new object();

        public uint Id { get; init; }
        public virtual string Name { get; init; }
        public IRoom Room { get; init; }

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

        public byte LastBodyDirection { get; private set; }
        public byte LastHeadDirection { get; private set; }
        private byte bodyDirection;
        private byte headDirection;

        public byte BodyDirection
        {
            get => bodyDirection;
            set
            {
                LastBodyDirection = bodyDirection;
                bodyDirection = value;
            }
        }
        public byte HeadDirection
        {
            get => headDirection;
            set
            {
                LastHeadDirection = headDirection;
                headDirection = value;
            }
        }

        public RoomUnit(IRoom room, string name) => (Room, Name) = (room, name);

        public void SetUpdateNeed(bool value)
        {
            UpdateNeeded = value;
        }
    }
}
