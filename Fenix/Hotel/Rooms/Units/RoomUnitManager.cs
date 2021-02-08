using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Microsoft.Extensions.Logging;
using Server.Hotel.Rooms.Units.Users;
using System;
using System.Collections.Concurrent;

namespace Server.Hotel.Rooms.Units
{
    class RoomUnitManager : IRoomUnitManager
    {
        private readonly object locker = new object();

        public IRoom Room { get; init; }
        private ILogger<IRoomUnitManager> logger { get; init; }
        private ConcurrentDictionary<uint, IRoomUnit> UnitsCoords { get; init; }
        private ushort _currentUnitId;
        private ushort CurrentUnitId
        {
            get => _currentUnitId;
            set
            {
                lock (locker) _currentUnitId = value;
            }
        }

        public RoomUnitManager(ILogger<IRoomUnitManager> logger, IRoom room)
        {
            this.logger = logger;
            Room = room;

            UnitsCoords = new ConcurrentDictionary<uint, IRoomUnit>();
        }

        public bool TryJoin(IHabbo habbo, out IRoomUser? roomUser)
        {
            roomUser = null;
            if (habbo is not IHabbo)
                throw new ArgumentException("Invalid argument", nameof(habbo));

            for (uint i = 0; i < UnitsCoords.Count; i++)
            {
                IRoomUnit unit = UnitsCoords[i];
                if (unit is IRoomUser user && user.Habbo.HabboProfile.Id == habbo.HabboProfile.Id)
                    TryRemove(unit.Id, out _);
            }

            roomUser = new RoomUser(CurrentUnitId++, Room)
            {
                Habbo = habbo,
            };

            bool sucess = UnitsCoords.TryAdd(roomUser.Id, roomUser);
            if (!sucess) roomUser = null;
            return sucess;
        }

        public bool TryAdd(IRoomUnit roomUnit)
        {
            return UnitsCoords.TryAdd(roomUnit.Id, roomUnit);
        }

        public bool TryRemove(uint roomUnitId, out IRoomUnit? roomUnit)
        {
            return UnitsCoords.TryRemove(roomUnitId, out roomUnit);
        }

    }
}
