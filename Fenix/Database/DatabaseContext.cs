using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Items;
using Fenix.Hotel.Rooms.Floor;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Database
{
    class DatabaseContext : DbContext, IDatabaseContext
    {
        private ILogger<IDatabaseContext> logger { get; init; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options, ILogger<IDatabaseContext> logger) : base(options) => this.logger = logger;

        public DbSet<HabboProfile> HabboProfiles { get; protected set; }
        public DbSet<RoomModel> RoomModels { get; protected set; }
        public DbSet<ItemData> ItemDatas { get; protected set; }

        //protected internal virtual void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel>(Model =>
            {
                Model.HasKey(Model => Model.Name)
                .HasName("Name");
            });
        }
    }
}
