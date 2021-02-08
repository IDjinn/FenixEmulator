using Api.Networking.Clients;
using System.Threading.Tasks;

namespace Api.Hotel.Habbos
{
    public interface IHabboManager
    {
        public ValueTask<IHabbo?> Login(IClient client);
    }
}
