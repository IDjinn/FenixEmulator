using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using System.Threading.Tasks;

namespace Api.Networking
{
    public interface IPacketManager
    {
        ValueTask HandlePacket(IClient client, IIncomingPacket packet);
    }
}
