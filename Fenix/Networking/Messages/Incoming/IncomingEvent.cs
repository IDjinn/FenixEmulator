using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;

namespace Server.Networking.Messages.Incoming
{
   public class IncomingEvent : IIncomingEvent
    {
        public virtual IPacketBucket? Bucket { get; protected set; }

        public virtual async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await ValueTask.CompletedTask;
        }
    }
}
