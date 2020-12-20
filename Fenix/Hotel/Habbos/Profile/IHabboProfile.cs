using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Habbos.Profile
{
    public interface IHabboProfile
    {
        public uint Id { get; init; }
        public string Username { get; init; }
        public String Look { get; init; }
        public uint Coins { get; set; }
        public Byte Rank { get; init; }
        public Byte Vip { get; init; }
        public Char Gender { get; init; }
        public String? Mail { get; init; }
        public String? IpRegister { get; init; }
        public String? IpLogin { get; init; }
        public String? MachineId { get;}
    }
}
