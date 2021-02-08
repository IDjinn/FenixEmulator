using Api.Util.Services;
using System.Threading.Tasks;

namespace Api.Hotel.Habbos.Profile
{
    public interface IHabboProfileService : IGenericProductService<IHabboProfile, uint>
    {
        public ValueTask<IHabboProfile?> FindHabboBySSO(string sso);
    }
}
