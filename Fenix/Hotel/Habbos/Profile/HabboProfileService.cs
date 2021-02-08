using Api.Hotel.Habbos.Profile;
using Api.Util.Cache;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Hotel.Habbos.Profile
{
    public class HabboProfileService : IHabboProfileService
    {
        private DatabaseContext databaseContext { get; init; }
        private IBaseCache<IHabboProfile> profilesCache { get; init; }
        public HabboProfileService(DatabaseContext databaseContext, IBaseCache<IHabboProfile> profilesCache)
        {
            this.databaseContext = databaseContext;
            this.profilesCache = profilesCache;
        }


        public async ValueTask<IHabboProfile?> FindHabboBySSO(string sso)
        {
            var profile = databaseContext.HabboProfiles.FirstOrDefault(profile => profile.SSO.Equals(sso));
            if (profile is null)
                return null;

            return await profilesCache.GetAsyncOrCreate(profile.Id, () => profile);
        }

        public ValueTask<List<IHabboProfile>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IHabboProfile?> GetAsync(uint key)
        {
            return await profilesCache.GetOrCreateAsync(key, async () => await databaseContext.HabboProfiles.FindAsync(key));
        }

        public ValueTask<IHabboProfile> UpdateAsync(IHabboProfile product)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteAsync(uint key)
        {
            throw new NotImplementedException();
        }
    }
}
