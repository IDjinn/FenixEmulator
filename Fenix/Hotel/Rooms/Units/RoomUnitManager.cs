using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Server.Hotel.Rooms.Units.Users;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms.Units
{
    class RoomUnitManager : IRoomUnitManager
    {
        private readonly object locker = new object();

        public IRoom Room { get; init; }
        private ILogger<IRoomUnitManager> logger { get; init; }
        private IServiceCollection services { get; init; }
        private IServiceProvider serviceProvider { get; init; }
        private ConcurrentDictionary<uint, IRoomUnit> UnitsCoords { get; init; }
        private ushort _currentUnitId;
        private ushort CurrentUnitId { get => _currentUnitId;
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

            services = new ServiceCollection();
            serviceProvider = services.BuildServiceProvider();
        }

        public bool TryJoin(IHabbo habbo, out IRoomUser? roomUser)
        {
            roomUser = null;
            if (habbo is not IHabbo)
                throw new ArgumentException(nameof(habbo), "Invalid argument");

            for (ushort i = 0; i < UnitsCoords.Count; i++)
            {
                IRoomUnit unit = UnitsCoords[i];
                if (unit is IRoomUser user && user.Habbo.HabboProfile.Id == habbo.HabboProfile.Id)
                    TryRemove(unit.Id, out _);
            }

            roomUser = new RoomUser
            {
                Id = (ushort)UnitsCoords.Count,
                Habbo = habbo,
                Room = Room,
            };

            bool sucess = UnitsCoords.TryAdd(CurrentUnitId++, (IRoomUnit)roomUser);
            if (!sucess) roomUser = null;
            return sucess;
        }

        public bool TryAdd(IRoomUnit roomUnit)
        {
            return UnitsCoords.TryAdd(roomUnit.Id, roomUnit);
        }

        public bool TryRemove(ushort roomUnitId, out IRoomUnit? roomUnit)
        {
            return UnitsCoords.TryRemove(roomUnitId, out roomUnit);
        }

        public object? GetService(Type serviceType)
        {
            return serviceProvider.GetService(serviceType);
        }
    }
}
