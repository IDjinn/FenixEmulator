using Api.Hotel.Habbos;
using System;
using System.Threading.Tasks;

namespace Api.Hotel.Rooms.Units
{
    public interface IRoomUnitManager : IServiceProvider
    {
        public IRoom Room { get; }


        public bool TryJoin(IHabbo habbo, out IRoomUser? roomUser);
        public bool TryAdd(IRoomUnit roomUnit);
        public bool TryRemove(ushort roomUnitId, out IRoomUnit? roomUnit);
    }
}