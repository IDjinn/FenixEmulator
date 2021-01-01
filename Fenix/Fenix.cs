using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Api.Networking;
using Server.Database;
using Api.Hotel.Items;
using Server.Hotel.Habbos;
using Api.Hotel.Rooms;
using Server.Networking;
using Server.Hotel.Rooms;
using Server.Hotel.Items;
using Api.Hotel.Habbos;
using Server.Util.Factories.Networking;
using Api.Networking.Clients;
using Api.Util.Factories.Networking;
using Api.Util.Factories.Hotel.Rooms;
using Api.Util.Cache;
using Server.Util.Cache;

namespace Server
{
    public class Fenix : IHostedService, IServiceProvider
    {
        public const string MAJOR = "1";
        public const string MINOR = "0";
        public const string PATCH = "0";
        public const string? PREVIEW = null;

        public const string LOGO = @"
███████╗███████╗███╗   ██╗██╗██╗  ██╗
██╔════╝██╔════╝████╗  ██║██║╚██╗██╔╝
█████╗  █████╗  ██╔██╗ ██║██║ ╚███╔╝ 
██╔══╝  ██╔══╝  ██║╚██╗██║██║ ██╔██╗ 
██║     ███████╗██║ ╚████║██║██╔╝ ██╗
╚═╝     ╚══════╝╚═╝  ╚═══╝╚═╝╚═╝  ╚═╝
                                     
";

        private ISocketManager socketManager { get; init; }
        private ILogger<Fenix> logger { get; init; }
        private IServiceCollection services { get; init; }
        private IServiceProvider provider { get; init; }
        private IConfiguration config { get; init; }

        public Fenix(ILogger<Fenix> logger, IConfiguration config)
        {
            this.logger = logger;
            this.config = config;
            logger.LogInformation(LOGO);
            logger.LogInformation($"\n\n\t\t\tVersion: {MAJOR}.{MINOR}.{PATCH}{(!string.IsNullOrWhiteSpace(PREVIEW) ? $"-{PREVIEW}" : "")}\n\n");

            try
            {
                services = new ServiceCollection();
                services.AddDbContext<IDatabaseContext, DatabaseContext>((options) => options.UseMySql(config.GetConnectionString("Habbo")));
                services.AddLogging();
                services.AddSingleton<IItemManager, ItemManager>();
                services.AddSingleton<ISocketManager, SocketManager>();
                services.AddSingleton<IHabboManager, HabboManager>();
                services.AddSingleton<IRoomManager, RoomManager>();

                // Factories
                services.AddSingleton<IClientFactory, ClientFactory<IClient>>();
                services.AddSingleton<IRoomFactory, RoomFactory<IRoom>>();

                services.AddTransient(typeof(IBaseCache<>), typeof(BaseCache<>));
                provider = services.BuildServiceProvider();

            }
            catch(Exception e) 
            { 
            }
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation($"Started....");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation($"Stoped....");
        }

        public object? GetService(Type serviceType)
        {
            return provider.GetService(serviceType);
        }
    }
}
    