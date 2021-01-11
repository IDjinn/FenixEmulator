using System.Threading.Tasks;

using Api.Networking.Clients;

namespace Api.Hotel.Habbos
{
    public interface IHabboManager
    {
        public ValueTask<IHabbo?> Login(IClient client);
    }
}
