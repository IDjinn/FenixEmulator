using Api.Util.Services;
using System.Threading.Tasks;

namespace Api.Hotel.Items
{
    public interface IITemDataService : IGenericProductService<IItemData, ushort>
    {
        public ValueTask InitAsync();
    }
}
