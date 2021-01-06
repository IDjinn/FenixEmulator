using System;

using Api.Hotel.Habbos;

namespace Api.Hotel.Rooms.Units
{
    public interface IRoomUnitManager
    {
        public IRoom Room { get; }


        public bool TryJoin(IHabbo habbo, out IRoomUser? roomUser);
        public bool TryAdd(IRoomUnit roomUnit);
        public bool TryRemove(ushort roomUnitId, out IRoomUnit? roomUnit);
    }
}