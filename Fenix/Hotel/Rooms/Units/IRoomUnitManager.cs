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
        public ValueTask<bool> TryJoin(IHabbo habbo, out IRoomUser roomUser);
        public ValueTask<bool> TryAdd(object unit, out IRoomUnit roomUnit);
    }
}