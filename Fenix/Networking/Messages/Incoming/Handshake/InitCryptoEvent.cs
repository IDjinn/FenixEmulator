using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    class InitCryptoEvent : IncomingEvent
    {
        public async override ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await base.Parse(packet, client);
        }
    }
}
