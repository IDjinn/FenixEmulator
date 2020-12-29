using Api.Networking.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotel.Habbos
{
    public interface IHabboManager
    {
        ValueTask<IHabboProfile?> GetProfileAsync(uint Id);
        ValueTask<IHabbo> LoadHabbo(IClient client);
    }
}
