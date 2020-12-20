using Fenix.Hotel.Habbos;
using Fenix.Hotel.Rooms.Units.Users;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units
{
    class RoomUnitManager : IRoomUnitManager
    {
        public IRoom Room { get; init; }
        private ILogger<IRoomUnitManager> logger { get; init; }
        private IServiceCollection services { get; init; }
        private IServiceProvider serviceProvider { get; init; }
        public RoomUnitManager(ILogger<IRoomUnitManager> logger, IRoom room)
        {
            this.logger = logger;
            Room = room;

            services = new ServiceCollection();
            serviceProvider = services.BuildServiceProvider();
        }

        public ValueTask<bool> TryJoin(IHabbo habbo, out IRoomUser roomUser)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> TryAdd(object unit, out IRoomUnit roomUnit)
        {
            throw new NotImplementedException();
        }

        public object? GetService(Type serviceType)
        {
            return serviceProvider.GetService(serviceType);
        }
    }
}
