using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;
using System.Threading.Tasks;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    public class PingEvent : IIncomingEvent
    {
        public PingEvent() { }
        public ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            return default;
        }
    }
}
