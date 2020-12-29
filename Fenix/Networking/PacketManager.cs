using Api.Networking;
using Api.Networking.Clients;
using Api.Networking.Messages;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Server.Networking.Messages.Incoming.Handshake;
using Server.Util.Cache;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Networking
{
    class PacketManager : IPacketManager
    {
        private Dictionary<int, IIncomingEvent> incomingEvents { get; init; }
        private BaseCache<IPacketBucket> packetsBucket { get; init; }
        private ILogger<IPacketManager> logger { get; init; }

        public PacketManager(ILogger<IPacketManager> logger)
        {
            this.logger = logger;
            incomingEvents = new Dictionary<int, IIncomingEvent>()
            {
                {0, new PingEvent() }
            };
            packetsBucket = new BaseCache<IPacketBucket>();
        }

        public async ValueTask HandlePacket(IClient client, IIncomingPacket packet)
        {
            if(!incomingEvents.TryGetValue(packet.Id, out IIncomingEvent? incomingEvent))
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

            if (!await Throttling(client, incomingEvent))
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
    }
}
