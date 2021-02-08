using System.Threading.Tasks;

namespace Server.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext databaseContext;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void Commit()
        {
            databaseContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return databaseContext.SaveChangesAsync();
        }

        public void RollBack()
        {

        }
    }
}
