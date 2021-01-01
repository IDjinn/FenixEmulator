using Api.Networking.Clients;
using System.Net.Sockets;

namespace Api.Util.Factories.Networking
{
    public interface IClientFactory
    {
        public IClient Create(Socket socket);
    }
}