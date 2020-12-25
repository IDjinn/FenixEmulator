using Fenix.Hotel.Habbos;
using Fenix.Hotel.Rooms.Units.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units
{
    public interface IRoomUnitManager : IServiceProvider
    {
        public IRoom Room { get; }


        public bool TryJoin(IHabbo habbo, out IRoomUser? roomUser);
        public bool TryAdd(IRoomUnit roomUnit);
        public bool TryRemove(ushort roomUnitId, out IRoomUnit? roomUnit);
    }
}