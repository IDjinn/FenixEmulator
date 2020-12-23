using Fenix.Hotel.Habbos.Profile;
using Fenix.Hotel.Items;
using Fenix.Hotel.Rooms.Floor;
using Microsoft.EntityFrameworkCore;

namespace Fenix.Database
{
    public interface IDatabaseContext
    {
        public DbSet<HabboProfile> HabboProfiles { get; }
        
        
        public DbSet<RoomModel> RoomModels { get; }


        public DbSet<ItemData> ItemDatas { get; }

    }
}