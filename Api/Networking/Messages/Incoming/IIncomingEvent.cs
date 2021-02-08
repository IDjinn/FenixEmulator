using Api.Networking.Clients;
using System.Threading.Tasks;

namespace Api.Networking.Messages.Incoming
{
    public interface IIncomingEvent
    {
        public ValueTask Execute(IIncomingPacket packet, IClient client);
    }
}
