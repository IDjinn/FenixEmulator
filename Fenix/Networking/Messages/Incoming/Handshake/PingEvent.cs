using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    class PingEvent : IncomingEvent
    {
        public override async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await base.Parse(packet, client);
        }
    }
}
