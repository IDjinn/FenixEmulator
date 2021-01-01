using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Util.Factories.Hotel.Rooms
{
    public class RoomFactory<TRoom> : IRoomFactory where TRoom : notnull, IRoom
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
