using Fenix.Networking.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fenix.Networking.Messages.Incoming;

namespace Fenix.Networking
{
    interface IPacketManager
    {
        ValueTask HandlePacket(IClient client, IIncomingPacket packet);
    }
}
