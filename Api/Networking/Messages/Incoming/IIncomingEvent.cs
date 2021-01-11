using System.Threading.Tasks;

using Api.Networking.Clients;

namespace Api.Networking.Messages.Incoming
{
    public interface IIncomingEvent
    {
        public ValueTask Execute(IIncomingPacket packet, IClient client);
    }
}
