using System.Threading.Tasks;

using Api.Util.Repository;

namespace Api.Hotel.Items
{
    public interface IItemDataRepository<TProduct, TKey> : IGenericRepository<TProduct, TKey>
    {
        public ValueTask InitAsync();
    }
}
