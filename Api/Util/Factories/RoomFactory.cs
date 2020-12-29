using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using Api.Util.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Factories
{
    public class RoomFactory<TRoom> : IRoomFactory where TRoom : IRoom
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
