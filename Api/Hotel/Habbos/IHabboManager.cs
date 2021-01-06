using System.Threading.Tasks;

using Api.Networking.Clients;

namespace Api.Hotel.Habbos
{
    public interface IHabboManager
    {
        ValueTask<IHabboProfile?> GetProfileAsync(uint Id);
        ValueTask<IHabbo> LoadHabbo(IClient client, IHabboProfile habboProfile);
    }
}
