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

namespace Fenix
{
    class Fenix : IHostedService
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

        public Fenix(ILogger<Fenix> logger, IFenixDatabaseContext dbContext)
        {
            this.logger = logger;
            logger.LogInformation(LOGO);
            logger.LogInformation($"\n\n\t\t\tVersion: {MAJOR}.{MINOR}.{PATCH}{(!string.IsNullOrWhiteSpace(PREVIEW) ? $"-{PREVIEW}" : "")}\n\n");

            dbContext.HabboProfiles.FindAsync()

            //socketManager = new SocketManager(port: 100);
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void OnStarted()
        {
            logger.LogInformation("Starting.");
        }

        private void OnStopping()
        {
            logger.LogInformation("Stopping");
        }

        private void OnStopped()
        {
            logger.LogInformation("Stopped");
        }
    }
}
    