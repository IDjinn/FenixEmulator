using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotel.Habbos
{
    public interface IHabboProfile
    {
        public uint Id { get; init; }
        public string Username { get; init; }
        public string? Motto { get; init; }
        public uint Credits { get; set; }
        public String Look { get; init; }
        public Byte Rank { get; init; }
        public Byte Vip { get; init; }
        public Char Gender { get; init; }
        public String? Mail { get; init; }
        public String? IpRegister { get; init; }
        public String? IpLogin { get; init; }
        public String? MachineId { get; }
    }
}
