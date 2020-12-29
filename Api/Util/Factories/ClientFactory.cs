using Api.Networking.Clients;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Factories
{
    public class ClientFactory<TClient> : IClientFactory<TClient> where TClient : class
    {
        private IServiceProvider serviceProvider { get; init; }

        public ClientFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public TClient Create(Socket socket)
        {
            var client = ActivatorUtilities.CreateInstance<TClient>(serviceProvider, socket);
            return client;
        }
    }
}
