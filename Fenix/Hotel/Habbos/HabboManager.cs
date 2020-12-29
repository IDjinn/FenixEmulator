using Server.Database;
using Api.Hotel.Habbos;
using Api.Networking;
using Api.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Util.Cache;
using Api.Networking.Clients;
using Server.Hotel.Habbos.Profile;

namespace Server.Hotel.Habbos
{
    sealed class HabboManager : IHabboManager
    {
        private BaseCache<IHabboProfile> profileCache { get; init; }
        private IDatabaseContext dbContext { get; init; }

        public HabboManager(IDatabaseContext dbContext)
        {
            profileCache = new BaseCache<IHabboProfile>();
            this.dbContext = dbContext;
        }

        public async ValueTask<IHabboProfile?> GetProfileAsync(uint Id)
        {
            return await profileCache.GetOrCreate(Id, async() => await dbContext.HabboProfiles.FindAsync(Id));
        }

        public ValueTask<IHabbo> LoadHabbo(IClient client)
        {
            if (!client.IsAuthentificated)
                throw new InvalidOperationException($"Not authenticated. '{nameof(client.IsAuthentificated)}' must be true for LoadHabbo.");

            if(string.IsNullOrEmpty(client.SSO))
                throw new ArgumentException("Invalid SSO.");

            if (client.Habbo is IHabbo)
                return new ValueTask<IHabbo>(client.Habbo);

            var userProfile = new HabboProfile();
            var habbo = new Habbo(client, userProfile);
            client.SetHabbo(habbo);

            return new ValueTask<IHabbo>(habbo);
        }
    }
}
