using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    class MachineIdEvent : IncomingEvent
    {
        public override async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await base.Parse(packet, client);

            _ = packet.ReadString();
            string MachineId = packet.ReadString();

            if (string.IsNullOrWhiteSpace(MachineId) || client.Habbo is null) return;

            // client.Habbo!.HabboProfile.MachineId = MachineId;
        }
    }
}
