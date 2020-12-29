using Api.Hotel.Habbos;
using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Util.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

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
            if (string.IsNullOrWhiteSpace(SSO))
                throw new NullReferenceException();

            client.SetSSO(SSO);
            // client.IsAuthentificated = true;
            // TODO: Load habbo
        }
    }
}
