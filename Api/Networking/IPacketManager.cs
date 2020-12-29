using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Networking
{
    public interface IPacketManager
    {
        ValueTask<bool> Throttling(IClient client, IIncomingEvent incomingEvent);
        ValueTask HandlePacket(IClient client, IIncomingPacket packet);
    }
}
