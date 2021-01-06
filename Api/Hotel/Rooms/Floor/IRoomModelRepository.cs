using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Util.Repository;

namespace Api.Hotel.Rooms.Floor
{
    public interface IRoomModelRepository<TProduct, TKey> :GenericRepository<TProduct, TKey>
    {
    }
}
