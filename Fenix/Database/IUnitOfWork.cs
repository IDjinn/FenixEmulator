using System.Threading.Tasks;

namespace Server.Database
{
    public interface IUnitOfWork
    {
        public void Commit();
        public Task<int> CommitAsync();
        public void RollBack();
    }
}