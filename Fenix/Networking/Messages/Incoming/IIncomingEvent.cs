using Fenix.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming
{
    interface IIncomingEvent
    {
        ValueTask Parse(IIncomingPacket packet, IClient client);
    }
}
