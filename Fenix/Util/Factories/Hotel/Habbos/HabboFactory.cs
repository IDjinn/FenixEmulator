using System;

using Api.Hotel.Habbos;
using Api.Networking.Clients;
using Api.Util.Factories.Hotel.Habbos;

using Microsoft.Extensions.DependencyInjection;

namespace Server.Util.Factories.Hotel.Habbos
{
    public class HabboFactory<THabo> : IHabboFactory where THabo : class, IHabbo
    {
        private IServiceProvider serviceProvider { get; init; }
        public HabboFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IHabbo Create(IClient client, IHabboProfile habboProfile)
        {
            var habbo = ActivatorUtilities.CreateInstance<THabo>(serviceProvider, client, habboProfile);
            return habbo;
        }
    }
}
