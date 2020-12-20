using Fenix.Hotel.Habbos.Profile;
using Fenix.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Habbos
{
    public interface IHabbo
    {
        public IClient Client { get; init; }
        public IHabboProfile HabboProfile { get; init; }
    }
}
