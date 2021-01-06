using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;

namespace Api.Networking
{
    public interface IPacketManager
    {
        ValueTask<bool> Throttling(IClient client, IIncomingEvent incomingEvent);
        ValueTask HandlePacket(IClient client, IIncomingPacket packet);
        ValueTask<bool> HandleScpecialPacket(IClient client, IIncomingPacket packet);
    }
}
