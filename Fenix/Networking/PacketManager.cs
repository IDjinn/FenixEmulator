using Fenix.Networking.Messages;
using Fenix.Networking.Messages.Incoming;
using Fenix.Networking.Messages.Incoming.Handshake;
using Fenix.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking
{
    class PacketManager : IPacketManager
    {
        private Dictionary<int, IIncomingEvent> incomingEvents { get; init; }

        public PacketManager()
        {
            incomingEvents = new Dictionary<int, IIncomingEvent>()
            {
                {0, new PingEvent() }
            };
        }

        public ValueTask HandlePacket(IClient client, IIncomingPacket packet)
        {
            if(!incomingEvents.TryGetValue(packet.Id, out IIncomingEvent? incomingEvent))
            {
                Console.WriteLine($"Incoming {packet.Id} not found");
                return ValueTask.CompletedTask;
            }

            var noAuthAtribbute = incomingEvent.GetType().GetCustomAttribute<NoAuth>();
            if (client.IsAuthentificated is false && noAuthAtribbute is null)
            {
                Console.WriteLine($"Event ${packet.Id} need auth, but client ${client.ConnectionId} hasnt auth");
                return ValueTask.CompletedTask;
            }


            return incomingEvent.Parse(packet, client);
        }
    }
}
