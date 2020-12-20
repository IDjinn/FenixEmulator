using Fenix.Hotel.Habbos.Profile;
using Fenix.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Habbos
{
    sealed class HabboManager : IHabboManager
    {
        public ValueTask<IHabbo> LoadHabbo(IClient client)
        {
            if (!client.IsAuthentificated)
                throw new InvalidOperationException($"Not authenticated. '{nameof(client.IsAuthentificated)}' must be true for LoadHabbo.");

            if(string.IsNullOrEmpty(client.SSO))
                throw new ArgumentException("Invalid SSO.");

            if (client.Habbo is IHabbo)
                return new ValueTask<IHabbo>(client.Habbo);

            var userProfile = new HabboProfile(Guid.NewGuid(), "username");
            var habbo = new Habbo(client, userProfile);
            client.SetHabbo(habbo);

            return new ValueTask<IHabbo>(habbo);
        }
    }
}
