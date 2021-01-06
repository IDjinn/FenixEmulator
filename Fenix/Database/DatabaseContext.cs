using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Server.Hotel.Habbos.Profile;
using Server.Hotel.Items;
using Server.Hotel.Rooms.Floor;
using Server.Hotel.Rooms.Info;

namespace Server.Database
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<HabboProfile> HabboProfiles { get; protected set; }
        public DbSet<RoomModel> RoomModels { get; protected set; }
        public DbSet<ItemData> ItemDatas { get; protected set; }
        public DbSet<RoomInfo> RoomInfos { get; protected set; }

        protected internal virtual void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseMySql(configuration.GetConnectionString("Habbo"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RoomInfo>(buildAction =>
            {
            });
            /*
            var profiles = new List<HabboProfile>()
            {
                new HabboProfile()
                {
                    Id = 1,
                    Username = "Lucas",
                    Motto = "Oi",
                    Look = "sjidawsdawsd",
                    Rank = 1,
                    Vip = 0,
                    Gender = 'M',
                    Credits = 100
                }
            };

            HabboProfiles.AddRange(profiles);
            SaveChanges();*/
        }
    }
}
