using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

using Server.Core.Encryption;
using Microsoft.Extensions.Logging;
using Server.Networking.Messages.Outgoing.Handshake;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    public class InitDiffieHandshakeEvent : IIncomingEvent
    {
        public ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            client.Send(new InitDiffieHandshakeComposer(HabboEncryptionV2.GetRsaDiffieHellmanPrimeKey(), HabboEncryptionV2.GetRsaDiffieHellmanGeneratorKey()));
            return default;
        }
    }
}
