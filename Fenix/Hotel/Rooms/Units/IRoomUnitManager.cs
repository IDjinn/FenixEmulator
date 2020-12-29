using Api.Hotel.Habbos;
using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Units;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms.Units
{
    public interface IRoomUnitManager : IServiceProvider
    {
        public IRoom Room { get; }


        public bool TryJoin(IHabbo habbo, out IRoomUser? roomUser);
        public bool TryAdd(IRoomUnit roomUnit);
        public bool TryRemove(ushort roomUnitId, out IRoomUnit? roomUnit);
    }
}