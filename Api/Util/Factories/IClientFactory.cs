using Api.Networking.Clients;
using System.Net.Sockets;

namespace Api.Util.Factories
{
    public interface IClientFactory<TClient>
    {
        public TClient Create(Socket socket);
    }
}