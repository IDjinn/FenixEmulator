using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Api.Util.Factories.Hotel.Rooms
{
    public class RoomFactory<TRoom> : IRoomFactory where TRoom : class, IRoom
    {
        private IServiceProvider serviceProvider { get; init; }
        public RoomFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IRoom Create(IRoomInfo roomInfo)
        {
            var room = ActivatorUtilities.CreateInstance<TRoom>(serviceProvider, roomInfo);
            return room;
        }
    }
}
