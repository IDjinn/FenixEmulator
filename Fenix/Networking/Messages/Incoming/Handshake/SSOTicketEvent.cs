using System;
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
    class SSOTicketEvent : IncomingEvent
    {
        public override async ValueTask Parse(IIncomingPacket packet, IClient client)
        {
            await base.Parse(packet, client);

            if (client.IsAuthentificated || !string.IsNullOrWhiteSpace(client.SSO) || client.Habbo is IHabbo)
                throw new SecurityException("Client already authenticated");

            string SSO = packet.ReadString(); // TODO: Internal filters from packet values.
            _ = packet.ReadInt();
            if (string.IsNullOrWhiteSpace(SSO))
                throw new NullReferenceException();

            client.SetSSO(SSO);
            client.Send(new SSOTicketOkComposer());
            // client.IsAuthentificated = true;
            // TODO: Load habbo
        }
    }
}
