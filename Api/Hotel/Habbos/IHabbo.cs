using Api.Networking.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotel.Habbos
{
    public interface IHabbo
    {
        public IClient Client { get; init; }
        public IHabboProfile HabboProfile { get; init; }
    }
}
