using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;

using Server.Core.Encryption;
using Server.Networking.Messages.Outgoing.Handshake;

namespace Server.Networking.Messages.Incoming.Handshake
{
    internal class CompleteDiffieHandshakeEvent : IIncomingEvent
    {
        public ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            var key = HabboEncryptionV2.CalculateDiffieHellmanSharedKey(packet.ReadString());
            if (key != 0)
            {
                client.SetARC4(new HabboEncryption.RC4(key.getBytes()));
                client.Send(new CompleteDiffieHandshakeComposer(HabboEncryptionV2.GetRsaDiffieHellmanPublicKey()));
            }

            return default;
        }
    }
}
