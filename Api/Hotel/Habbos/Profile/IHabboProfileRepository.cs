using System.Threading.Tasks;

using Api.Util.Repository;

namespace Api.Hotel.Habbos.Profile
{
    public interface IHabboProfileRepository : IGenericRepository<IHabboProfile, uint>
    {
        public ValueTask<IHabboProfile?> FindHabboBySSO(string sso);
    }
}
