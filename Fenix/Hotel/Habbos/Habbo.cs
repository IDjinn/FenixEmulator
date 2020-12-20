using Fenix.Hotel.Habbos.Profile;
using Fenix.Networking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Habbos
{

    public sealed record Habbo : IHabbo
    {
        public IClient Client { get; init; }
        public IHabboProfile HabboProfile { get; init; }
        public Habbo(IClient client, IHabboProfile habboProfile) => (Client, HabboProfile) = (client, habboProfile);
    }
}
