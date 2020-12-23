using Fenix.Networking;
using Fenix.Networking.Messages.Incoming;
using Fenix.Util;
using Fenix.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.Threading;
using Fenix.Database;
using Microsoft.Extensions.DependencyInjection;
using Fenix.Util.Cache;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Fenix.Hotel.Habbos;
using System.Diagnostics;
using Fenix.Hotel.Rooms;
using Fenix.Hotel.Items;

namespace Fenix
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
            }
            catch(Exception e) 
            { 
            }
            provider = services.BuildServiceProvider();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var stopWatch = new Stopwatch();
            var manager = provider.GetService(typeof(IItemManager)) as IItemManager;
            stopWatch.Start();
            var profile = await manager!.LoadItemsAsync()!;
            stopWatch.Stop();
            logger.LogInformation($"Passou {stopWatch.ElapsedMilliseconds}");
            stopWatch.Reset();
            stopWatch.Stop();
            logger.LogInformation($"Passou {stopWatch.ElapsedMilliseconds}");
            /*
            var stopWatch = new Stopwatch();
            var manager = provider.GetService(typeof(IHabboManager)) as IHabboManager;
            stopWatch.Start();
            var profile = await manager!.GetProfile(1)!;
            stopWatch.Stop();
            logger.LogInformation($"Passou {stopWatch.ElapsedMilliseconds}");
            stopWatch.Reset();
            stopWatch.Start();
            var profile2 = await manager!.GetProfile(2)!;
            stopWatch.Stop();
            logger.LogInformation($"Passou {stopWatch.ElapsedMilliseconds}");*/
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
    