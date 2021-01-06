using System.Collections.Concurrent;
using System.Threading.Tasks;

using Api.Hotel.Habbos;
using Api.Networking.Clients;
using Api.Util.Cache;
using Api.Util.Factories.Hotel.Habbos;

using Server.Database;

namespace Server.Hotel.Habbos
{
    sealed class HabboManager : IHabboManager
    {
        private IBaseCache<IHabboProfile> profileCache { get; init; }
        private IDatabaseContext dbContext { get; init; }
        private IHabboFactory habboFactory { get; init; }
        private ConcurrentDictionary<uint, IHabbo> onlineUsers { get; init; }

        public HabboManager(IDatabaseContext dbContext, IBaseCache<IHabboProfile> profileCache, IHabboFactory habboFactory)
        {
            onlineUsers = new ConcurrentDictionary<uint, IHabbo>();
            this.profileCache = profileCache;
            this.dbContext = dbContext;
            this.habboFactory = habboFactory;
        }

        public async ValueTask<IHabboProfile?> GetProfileAsync(uint Id)
        {
            return await profileCache.GetOrCreateAsync(Id, async () => await dbContext.HabboProfiles.FindAsync(Id));
        }

        public ValueTask<IHabbo> LoadHabbo(IClient client, IHabboProfile habboProfile)
        {/* TODO: Remove this
            if (!client.IsAuthentificated)
                throw new InvalidOperationException($"Not authenticated. '{nameof(client.IsAuthentificated)}' must be true for LoadHabbo.");

            if(string.IsNullOrEmpty(client.SSO))
                throw new ArgumentException("Invalid SSO.");

            if (client.Habbo is IHabbo habbo)
                return new ValueTask<IHabbo>(habbo);

            var userProfile = new HabboProfile();
            habbo = new Habbo(client, userProfile);
            client.SetHabbo(habbo);
            */

            return new ValueTask<IHabbo>(habboFactory.Create(client, habboProfile));
        }
    }
}
