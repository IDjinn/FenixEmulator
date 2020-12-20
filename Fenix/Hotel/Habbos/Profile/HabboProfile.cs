using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Habbos.Profile
{
    public sealed record HabboProfile : IHabboProfile
    {
        private static readonly object locker = new object();

        public uint Id { get; init; }
        public string Username { get; init; }
        public string Motto { get; init; }
        public String Look { get; init; }
        public Byte Rank { get; init; }
        public Byte Vip { get; init; }
        public Char Gender { get; init; }
        public String? Mail { get; init; }
        public String? IpRegister { get; init; }
        public String? IpLogin { get; init; }
        public String? MachineId { get; internal set; }

        private uint _coins { get; set; }
        public uint Coins
        {
            get => _coins;
            set
            {
                lock (locker)
                {
                    _coins = value;
                }
            }
        }
    }
}
