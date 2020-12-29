using Api.Hotel.Habbos;
using Api.Networking.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Habbos
{

    public sealed record Habbo : IHabbo
    {
        public IClient Client { get; init; }
        public IHabboProfile HabboProfile { get; init; }
        public Habbo(IClient client, IHabboProfile habboProfile) => (Client, HabboProfile) = (client, habboProfile);
    }
}
