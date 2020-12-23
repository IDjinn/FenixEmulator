using Fenix.Database;
using Fenix.Hotel.Rooms.Floor;
using Fenix.Hotel.Rooms.Info;
using Fenix.Hotel.Rooms.Units;
using Fenix.Networking.Messages.Outgoing;
using Fenix.Util.Cache;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms
{
    public record Room : IRoom
    {
        public uint Id { get; init; }
        public IRoomInfo RoomInfo { get; init; }
        public IRoomModel RoomModel { get; init; }
        
        private IServiceCollection services { get; init; }
        private IServiceProvider serviceProvider { get; init; }
        private ILogger<IRoom> logger { get; init; }
        private IDatabaseContext databaseContext { get; init; }

        public Room(ILogger<IRoom> logger, IRoomInfo roomInfo, IDatabaseContext databaseContext)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            Id = roomInfo.Id;
            RoomInfo = roomInfo;
            services = new ServiceCollection();
            services.AddScoped<IRoomUnitManager, RoomUnitManager>();

            serviceProvider = services.BuildServiceProvider();
        }

        public object? GetService(Type serviceType)
        {
            return serviceProvider.GetRequiredService(serviceType);
        }
    }
}
