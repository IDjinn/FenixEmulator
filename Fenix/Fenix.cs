using System;
using System.Threading;
using System.Threading.Tasks;

using Api.Hotel.Habbos;
using Api.Hotel.Items;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Floor;
using Api.Hotel.Rooms.Info;
using Api.Networking;
using Api.Networking.Clients;
using Api.Util.Cache;
using Api.Util.Factories.Hotel.Habbos;
using Api.Util.Factories.Hotel.Rooms;
using Api.Util.Factories.Networking;

using BenchmarkDotNet.Running;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Server.Database;
using Server.Hotel.Habbos;
using Server.Hotel.Items;
using Server.Hotel.Rooms;
using Server.Hotel.Rooms.Floor;
using Server.Hotel.Rooms.Info;
using Server.Networking;
using Server.Util.Cache;
using Server.Util.Factories.Hotel.Habbos;
using Server.Util.Factories.Networking;

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
        private IItemManager itemManager { get; init; }
        private ILogger<Fenix> logger { get; init; }
        private IServiceCollection services { get; init; }
        private IServiceProvider provider { get; init; }

        public Fenix(ILogger<Fenix> logger, IItemManager itemManager, ISocketManager socketManager)
        {
            this.logger = logger;
            logger.LogInformation(LOGO);
            logger.LogInformation($"\n\n\t\t\tVersion: {MAJOR}.{MINOR}.{PATCH}{(!string.IsNullOrWhiteSpace(PREVIEW) ? $"-{PREVIEW}" : "")}\n\n");


            this.itemManager = itemManager;
            this.socketManager = socketManager;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            socketManager.StartListener();
            BenchmarkRunner.Run<ItemManager>();
           // await itemManager.Init();
            logger.LogInformation($"Started....");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            socketManager.StopListener();
            logger.LogInformation($"Stoped....");
        }

        public object? GetService(Type serviceType)
        {
            return provider.GetService(serviceType);
        }
    }
}
