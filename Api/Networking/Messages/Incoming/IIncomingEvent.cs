using Api.Networking.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Networking.Messages.Incoming
{
    interface IIncomingEvent
    {
        public IPacketBucket? Bucket { get; }
        ValueTask Parse(IIncomingPacket packet, IClient client);
    }
}
