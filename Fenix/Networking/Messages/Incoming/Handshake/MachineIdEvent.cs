using System.Threading.Tasks;

using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    public class MachineIdEvent : IIncomingEvent
    {
        public MachineIdEvent() { }
        public ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            _ = packet.ReadString();
            string MachineId = packet.ReadString();

            if (string.IsNullOrWhiteSpace(MachineId) || client.Habbo is null) return default;

            // client.Habbo!.HabboProfile.MachineId = MachineId;
            return default;
        }
    }
}
