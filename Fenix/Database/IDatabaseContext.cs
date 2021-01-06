using Microsoft.EntityFrameworkCore;

using Server.Hotel.Habbos.Profile;
using Server.Hotel.Items;
using Server.Hotel.Rooms.Floor;
using Server.Hotel.Rooms.Info;

namespace Server.Database
{
    public interface IDatabaseContext
    {
        public DbSet<HabboProfile> HabboProfiles { get; }


        public DbSet<RoomModel> RoomModels { get; }
        public DbSet<RoomInfo> RoomInfos { get; }


        public DbSet<ItemData> ItemDatas { get; }


    }
}