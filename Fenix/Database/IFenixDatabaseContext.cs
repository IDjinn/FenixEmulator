using Fenix.Hotel.Habbos.Profile;
using Microsoft.EntityFrameworkCore;

namespace Fenix.Database
{
    internal interface IFenixDatabaseContext
    {
        public DbSet<HabboProfile> HabboProfiles { get; init; }
    }
}