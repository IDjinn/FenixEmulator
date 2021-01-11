using System.Security;
using System.Threading.Tasks;

using Api.Hotel.Habbos;
using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;

using Server.Networking.Messages.Outgoing.Handshake;

namespace Server.Networking.Messages.Incoming.Handshake
{
    [NoAuth]
    internal class SecureLoginEvent : IIncomingEvent
    {
        private IHabboManager habboManager { get; init; }
        public SecureLoginEvent(IHabboManager habboManager)
        {
            this.habboManager = habboManager;
        }

        public async ValueTask Execute(IIncomingPacket packet, IClient client)
        {
            if (client.IsAuthentificated || !string.IsNullOrWhiteSpace(client.SSO) || client.Habbo is IHabbo)
                throw new SecurityException("Client already authenticated");

            string SSO = packet.ReadString(); // TODO: Internal filters from packet values.
            _ = packet.ReadInt();
            if (string.IsNullOrWhiteSpace(SSO))
                throw new SecurityException();

            client.SetSSO(SSO);

            var habbo = await habboManager.Login(client);
            if (habbo is not IHabbo)
                throw new SecurityException();

            client.SetHabbo(habbo);
            client.Send(new SecureLoginOKComposer());
        }
    }
}
