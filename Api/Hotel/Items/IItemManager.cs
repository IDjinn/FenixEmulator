using System.Threading.Tasks;

namespace Api.Hotel.Items
{
    public interface IItemManager
    {
        public ValueTask Init();
    }
}