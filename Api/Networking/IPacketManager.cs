using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;

namespace Api.Networking
{
    public interface IPacketManager
    {
        ValueTask HandlePacket(IClient client, IIncomingPacket packet);
    }
}
