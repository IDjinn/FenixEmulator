using Fenix.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    class PingEvent : IncomingEvent
    {
        public override async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await base.Parse(packet, client);
        }
    }
}
