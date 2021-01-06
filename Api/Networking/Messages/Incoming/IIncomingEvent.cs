using System.Threading.Tasks;

using Api.Networking.Clients;

namespace Api.Networking.Messages.Incoming
{
    public interface IIncomingEvent
    {
        public IPacketBucket? Bucket { get; }
        ValueTask Parse(IIncomingPacket packet, IClient client);
    }
}
