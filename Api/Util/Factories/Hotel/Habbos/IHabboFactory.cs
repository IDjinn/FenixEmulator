using Api.Hotel.Habbos;
using Api.Networking.Clients;

namespace Api.Util.Factories.Hotel.Habbos
{
    public interface IHabboFactory
    {
        public IHabbo Create(IClient client, IHabboProfile habboProfile);
    }
}
