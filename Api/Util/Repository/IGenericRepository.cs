using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Util.Repository
{
    public interface IGenericRepository<TProduct, TKey>
    {
        public ValueTask<List<TProduct>> GetAllAsync();
        public ValueTask<TProduct?> GetAsync(TKey key);
        public ValueTask<TProduct> UpdateAsync(TProduct product);
        public ValueTask DeleteAsync(TKey key);
    }
}
