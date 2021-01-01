using Api.Networking.Clients;
using Api.Util.Factories;
using Api.Util.Factories.Networking;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Util.Factories.Networking
{
    public class ClientFactory<TClient> : IClientFactory where TClient : notnull, IClient
    {
        private IServiceProvider serviceProvider { get; init; }

        public ClientFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IClient Create(Socket socket)
        {
            var client = ActivatorUtilities.CreateInstance<IClient>(serviceProvider, socket);
            return client;
        }
    }
}
