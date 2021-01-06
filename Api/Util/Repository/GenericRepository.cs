using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Repository
{
    public interface GenericRepository<TProduct, TKey>
    {
        public ValueTask<List<TProduct>> GetAll();
        public ValueTask<TProduct?> Get(TKey key);
        public ValueTask<TProduct> Update(TProduct product);
        public ValueTask Delete(TKey key);
    }
}
