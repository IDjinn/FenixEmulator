using System;
using System.IO;

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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Serilog;

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
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
                {
                    Console.WriteLine(eventArgs.Exception.ToString());
                };
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex.ToString());
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IConfiguration CreateConfiguration(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.AddJsonFile("config.json", true);
            configurationBuilder.AddJsonFile("config.Development.json", true);
            configurationBuilder.AddEnvironmentVariables(prefix: "FENIX_");
            configurationBuilder.AddCommandLine(args);

            return configurationBuilder.Build();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configuration = CreateConfiguration(args);

            return Host.CreateDefaultBuilder(args)
                .UseContentRoot(Directory.GetCurrentDirectory())
#if DEBUG
                .UseEnvironment(Environment.GetEnvironmentVariable("FENIX_ENV") ?? "Development")
#else
                .UseEnvironment("Production")
#endif
                .ConfigureAppConfiguration(builder =>
                {
                    builder.AddConfiguration(configuration);
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureServices((host, services) =>
                {
                    services.AddTransient<IDatabaseContext, DatabaseContext>(serviceProvider =>
                    {
                        return ActivatorUtilities.CreateInstance<DatabaseContext>(serviceProvider, new DbContextOptionsBuilder().UseMySql(configuration.GetConnectionString("Habbo")).Options);
                    });

                    services.AddSingleton<IItemManager, ItemManager>();
                    services.AddSingleton<IPacketManager, PacketManager>();
                    services.AddSingleton<ISocketManager, SocketManager>();
                    services.AddSingleton<IHabboManager, HabboManager>();
                    services.AddSingleton<IRoomManager, RoomManager>();

                    // Factories
                    services.AddSingleton<IClientFactory, ClientFactory<Client>>();
                    services.AddSingleton<IRoomFactory, RoomFactory<Room>>();
                    services.AddSingleton<IHabboFactory, HabboFactory<Habbo>>();

                    //Repository
                    services.AddSingleton<IRoomModelRepository<IRoomModel, string>, RoomModelRepository>();
                    services.AddSingleton<IRoomInfoRepository<IRoomInfo, uint>, RoomInfoRepository>();

                    services.AddTransient(typeof(IBaseCache<>), typeof(BaseCache<>));



                    services.AddHostedService<Fenix>();
                })
                .UseConsoleLifetime();
        }
    }
}
