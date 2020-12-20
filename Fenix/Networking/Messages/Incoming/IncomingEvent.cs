using Fenix.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming
{
    class IncomingEvent : IIncomingEvent
    {
        public IncomingEvent()
        {
            Console.WriteLine("here with auth");
        }
        public virtual async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await ValueTask.CompletedTask;
        }
    }
}
