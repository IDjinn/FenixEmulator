using System.Threading;
using System.Threading.Tasks;

using Api.Hotel.Items;
using Api.Networking;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Server
{
    public class Fenix : IHostedService
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

        public Fenix(ILogger<Fenix> logger, IItemManager itemManager, ISocketManager socketManager, IPacketManager packetManager)
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
            await itemManager.Init();
            logger.LogInformation($"Started....");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            socketManager.StopListener();
            logger.LogInformation($"Stoped....");
        }
    }
}
