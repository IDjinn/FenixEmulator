using Fenix.Hotel.Habbos.Profile;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Database
{
    class FenixDatabaseContext : DbContext, IFenixDatabaseContext
    {
        private ILogger<IFenixDatabaseContext> logger { get; init; }
        public FenixDatabaseContext(DbContextOptions<FenixDatabaseContext> options, ILogger<IFenixDatabaseContext> logger) : base(options) => this.logger = logger;
    
        public DbSet<HabboProfile> HabboProfiles { get; init; }
    }
}
