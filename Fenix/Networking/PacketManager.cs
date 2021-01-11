using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Threading.Tasks;

using Api.Networking;
using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;
using Api.Util.Cache;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Server.Networking.Messages.Incoming;
using Server.Networking.Messages.Incoming.Handshake;
using Server.Util;

namespace Server.Networking
{
    class PacketManager : IPacketManager
    {
        private Dictionary<ushort, IIncomingEvent> incomingEvents { get; init; }
        private IBaseCache<IPacketBucket> packetsBucket { get; init; }
        private ILogger<IPacketManager> logger { get; init; }
        private IServiceProvider provider { get; init; }

        public PacketManager(IServiceProvider provider, ILogger<IPacketManager> logger, IBaseCache<IPacketBucket> packetsBucket)
        {
            this.logger = logger;
            this.packetsBucket = packetsBucket;
            this.provider = provider;
            incomingEvents = new Dictionary<ushort, IIncomingEvent>();

            RegisterIncoming(IncomingPacketsHeader.InitDiffieHandshake, typeof(InitDiffieHandshakeEvent));
            RegisterIncoming(IncomingPacketsHeader.PingEvent, typeof(PingEvent));
            RegisterIncoming(IncomingPacketsHeader.ReleaseVersionEvent, typeof(ReleaseVersionEvent));
            RegisterIncoming(IncomingPacketsHeader.SecureLoginEvent, typeof(SecureLoginEvent));
            RegisterIncoming(IncomingPacketsHeader.MachineIDEvent, typeof(MachineIdEvent));
            RegisterIncoming(IncomingPacketsHeader.PolicyRequestEvent, typeof(PolicyRequestEvent));
        }

        public async ValueTask HandlePacket(IClient client, IIncomingPacket packet)
        {
            logger.LogInformation($"Id {packet.Id} packet incoming size: {packet.Size}");

            if (await HandleScpecialPacket(client, packet))
            {
                return;
            }

            if (!incomingEvents.TryGetValue(packet.Id, out IIncomingEvent? incomingEvent))
            {
                logger.LogWarning($"Incoming {packet.Id} not found");
                return;
            }

            var noAuthAtribbute = incomingEvent.GetType().GetCustomAttribute<NoAuth>();
            if (client.IsAuthentificated is false && noAuthAtribbute is null)
            {
                logger.LogWarning($"Event ${packet.Id} need auth, but client ${client.ConnectionId} hasnt auth");
                return;
            }

            if (await IsThrottling(client, incomingEvent))
            {
                logger.LogWarning($"Client '{client.ConnectionId}' was locked by throttling (packet {nameof(incomingEvent)})");
                return;
            }

            try
            {
                await incomingEvent.Execute(packet, client);
            }
            catch (SecurityException securityException)
            {
                logger.LogWarning($"Security exception: {securityException}");
            }
        }

        private async ValueTask<bool> IsThrottling(IClient client, IIncomingEvent incomingEvent)
        {
            if (incomingEvent is not IPacketBucket bucket)
                return false;

            var now = DateTime.Now.Ticks;
            var resetAt = now + bucket.ResetBucketAt;
            var cacheOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromMilliseconds(bucket.ResetBucketAt));

            var packetBucket = await packetsBucket.GetAsyncOrCreate(
                string.Concat('-', client.ConnectionId, bucket.GetHashCode()),
                () => new PacketBucket(bucket.Tokens, resetAt),
                cacheOptions);

            if (packetBucket is null || now > packetBucket.ResetBucketAt)
                return false;

            packetBucket.Tokens--;
            return packetBucket.Tokens <= 0;
        }

        private ValueTask<bool> HandleScpecialPacket(IClient client, IIncomingPacket packet)
        {
            if (packet.Buffer[0] == 60)
            {
                client.Send(Constants.POLICY_REQUEST_RESPONSE);
                return new ValueTask<bool>(true);
            }

            return new ValueTask<bool>(false);
        }

        private void RegisterIncoming(ushort id, Type incomingEvent)
        {
            var instance = ActivatorUtilities.CreateInstance<IIncomingEvent>(provider, incomingEvent);
            incomingEvents.Add(id, instance);
        }
    }
}
