using Fenix.Hotel.Habbos.Profile;
using Fenix.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Habbos
{
    interface IHabboManager
    {
        ValueTask<IHabboProfile?> GetProfileAsync(uint Id);
        ValueTask<IHabbo> LoadHabbo(IClient client);
    }
}
