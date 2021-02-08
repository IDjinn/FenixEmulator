using Api.Networking.Clients;
using Api.Util.Factories.Networking;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Sockets;

namespace Server.Util.Factories.Networking
{
    public class ClientFactory<TClient> : IClientFactory where TClient : class, IClient
    {
        private IServiceProvider serviceProvider { get; init; }

        public ClientFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IClient Create(Socket socket)
        {
            var client = ActivatorUtilities.CreateInstance<TClient>(serviceProvider, socket);
            return client;
        }
    }
}
