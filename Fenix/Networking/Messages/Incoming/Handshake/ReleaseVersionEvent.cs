using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    public class ReleaseVersionEvent : IIncomingEvent
    {
        public ReleaseVersionEvent() { }
        public ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            return default;

            //_ = packet.ReadString();
            //_ = packet.ReadString();
            //_ = packet.ReadShort();
            //_ = packet.ReadShort();
        }
    }
}
