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
        ValueTask<IHabbo> LoadHabbo(IClient client);
    }
}
