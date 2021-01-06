using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

using Api.Networking;
using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;
using Api.Util.Cache;

using Microsoft.Extensions.Logging;

using Server.Networking.Messages.Incoming;
using Server.Networking.Messages.Incoming.Handshake;
using Server.Util;

namespace Server.Networking
{
    class PacketManager : IPacketManager
    {
        private Dictionary<int, IIncomingEvent> incomingEvents { get; init; }
        private IBaseCache<IPacketBucket> packetsBucket { get; init; }
        private ILogger<IPacketManager> logger { get; init; }

        public PacketManager(ILogger<IPacketManager> logger, IBaseCache<IPacketBucket> packetsBucket)
        {
            this.logger = logger;
            this.packetsBucket = packetsBucket;
            incomingEvents = new Dictionary<int, IIncomingEvent>()
            {
                {IncomingPacketsHeader.InitDiffieHandshake, new InitCryptoEvent() },
                {IncomingPacketsHeader.PingEvent, new PingEvent() },
                {IncomingPacketsHeader.ReleaseVersionEvent, new ReleaseVersionEvent() },
                {IncomingPacketsHeader.SecureLoginEvent, new SSOTicketEvent() },
                {IncomingPacketsHeader.MachineIDEvent, new MachineIdEvent() },
                {IncomingPacketsHeader.PolicyRequestEvent, new PolicyRequestEvent() },
            };
        }

        public async ValueTask HandlePacket(IClient client, IIncomingPacket packet)
        {
            if(await HandleScpecialPacket(client, packet))
            {
               return;
            }

            if (!incomingEvents.TryGetValue(packet.Id, out IIncomingEvent? incomingEvent))
            {
                logger.LogInformation($"Incoming {packet.Id} not found");
                return;
            }

            var noAuthAtribbute = incomingEvent.GetType().GetCustomAttribute<NoAuth>();
            if (client.IsAuthentificated is false && noAuthAtribbute is null)
            {
                logger.LogWarning($"Event ${packet.Id} need auth, but client ${client.ConnectionId} hasnt auth");
                return;
            }

            if (await Throttling(client, incomingEvent) is false)
            {
                logger.LogWarning($"Client '{client.ConnectionId}' was locked by throttling (packet {nameof(incomingEvent)})");
                return;
            }


            await incomingEvent.Parse(packet, client);
        }

        public async ValueTask<bool> Throttling(IClient client, IIncomingEvent incomingEvent)
        {
            return true;
        }

        public ValueTask<bool> HandleScpecialPacket(IClient client, IIncomingPacket packet)
        {
            if(packet.Buffer[0] == 60)
            {
                client.Send(Constants.POLICY_REQUEST_RESPONSE);
                return new ValueTask<bool>(true);
            }

            return new ValueTask<bool>(false);
        }
    }
}
