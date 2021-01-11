using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    internal class PingEvent : IIncomingEvent
    {
        public ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            return default;
        }
    }
}
