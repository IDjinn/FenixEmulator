using Api.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Networking.Messages.Incoming
{
    class IncomingEvent : IIncomingEvent
    {
        public virtual IPacketBucket? Bucket { get; protected set; }

        public virtual async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await ValueTask.CompletedTask;
        }
    }
}
