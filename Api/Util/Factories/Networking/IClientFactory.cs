using System.Net.Sockets;

using Api.Networking.Clients;

namespace Api.Util.Factories.Networking
{
    public interface IClientFactory
    {
        public IClient Create(Socket socket);
    }
}