using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming.Handshake
{
    class MachineIdEvent : IncomingEvent
    {
        public override async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await base.Parse(packet, client);

            _ = packet.ReadString();
            string MachineId = packet.ReadString();

            if (string.IsNullOrWhiteSpace(MachineId) || client.Habbo is null) return;

            client.Habbo.HabboProfile.MachineId = MachineId;
        }
    }
}
