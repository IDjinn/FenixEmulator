using System;
using System.ComponentModel.DataAnnotations.Schema;

using Api.Hotel.Habbos.Profile;

namespace Server.Hotel.Habbos.Profile
{
    [Table("users_profiles")]
    public sealed record HabboProfile : IHabboProfile
    {
        private readonly object locker = new object();

        public uint Id { get; init; }
        public string Username { get; init; }
        public string? Motto { get; init; }
        public String Look { get; init; }
        public Byte Rank { get; init; }
        public Byte Vip { get; init; }
        public Char Gender { get; init; }
        public String? Mail { get; init; }
        public String? IpRegister { get; init; }
        public String? IpLogin { get; init; }
        public String? MachineId { get; private set; }
        public string SSO { get; }

        [NotMapped]
        private uint credits { get; set; }

        public uint Credits
        {
            get => credits;
            set
            {
                lock (locker)
                {
                    credits = value;
                }
            }
        }
    }
}
