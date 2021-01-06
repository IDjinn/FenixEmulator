using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Hotel.Rooms.Info;
using Api.Util.Repository;

namespace Api.Hotel.Rooms.Info
{
    public interface IRoomInfoRepository<TProduct, TKey> : GenericRepository<TProduct, TKey>
    {

    }
}
