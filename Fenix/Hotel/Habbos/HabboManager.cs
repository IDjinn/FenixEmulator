using Api.Hotel.Habbos;
using Api.Hotel.Habbos.Profile;
using Api.Networking.Clients;
using Api.Util.Factories.Hotel.Habbos;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Server.Hotel.Habbos
{
    sealed class HabboManager : IHabboManager
    {
        private IHabboFactory habboFactory { get; init; }
        private ConcurrentDictionary<uint, IHabbo> onlineUsers { get; init; }
        private IHabboProfileService habboProfileRepository { get; init; }

        public HabboManager(IHabboProfileService habboProfileRepository, IHabboFactory habboFactory)
        {
            onlineUsers = new ConcurrentDictionary<uint, IHabbo>();
            this.habboProfileRepository = habboProfileRepository;
            this.habboFactory = habboFactory;
        }


        public async ValueTask<IHabbo?> Login(IClient client)
        {
            CheckLogin(client);

            if (client.Habbo is IHabbo habbo)
                return habbo;

            var profile = await habboProfileRepository.FindHabboBySSO(client.SSO!);
            if (profile is not IHabboProfile)
                return null;

            return habboFactory.Create(client, profile);
        }

        private static void CheckLogin(IClient client)
        {
            if (!client.IsAuthentificated)
                throw new InvalidOperationException($"Not authenticated. '{nameof(client.IsAuthentificated)}' must be true for LoadHabbo.");

            if (string.IsNullOrEmpty(client.SSO))
                throw new ArgumentException("Invalid SSO.");
        }
    }
}
