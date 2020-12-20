using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Fenix.Networking;
using Fenix.Hotel.Habbos;
using Fenix.Database;
using Microsoft.EntityFrameworkCore;

namespace Fenix
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var logLevel = LogEventLevel.Debug;
#else
            var logLevel = LogEventLevel.Information;
#endif

            if (args.Contains("--verbose"))
            {
                logLevel = LogEventLevel.Verbose;
            }
            else if (args.Contains("--errors-only"))
            {
                logLevel = LogEventLevel.Error;
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Is(logLevel)
#if DEBUG
                .MinimumLevel.Override("Microsoft", LogEventLevel.Debug)
#else
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
#endif
                .Enrich.FromLogContext()
                .CreateLogger();

            try
            {
                CreateHostBuilder(args).Build().Run();
                Console.ReadLine();
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
                .ConfigureServices((host, services) =>
                {
                    services.AddHostedService<Fenix>();
                    services.AddSingleton<SocketManager>();
                    services.AddSingleton<IHabboManager, HabboManager>();
                    services.AddDbContext<FenixDatabaseContext>(options =>
                    {
                        options.UseMySql("Server=127.0.1;Database=habbo;Uid=root;Pwd=root;");
                    });
                })
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
                .UseConsoleLifetime();
        }
    }
}
