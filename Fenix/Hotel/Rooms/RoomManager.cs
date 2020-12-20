using Fenix.Hotel.Rooms.Units;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms
{
    sealed class RoomManager : IRoomManager
    {
        private ConcurrentDictionary<uint, IRoom> loadedRooms { get; init; }
        private ILogger<IRoomManager> logger { get; init; }
        public RoomManager(ILogger<IRoomManager> logger)
        {
            this.logger = logger;
            loadedRooms = new ConcurrentDictionary<uint, IRoom>();
        }

        public ValueTask<IRoom> LoadRoom(uint roomId)
        {
            if (loadedRooms.TryGetValue(roomId, out IRoom? cachedRoom) && cachedRoom is IRoom)
                return new ValueTask<IRoom>(cachedRoom);

            // Remove from dict if it is not a valid IRoom.
            loadedRooms.TryRemove(roomId, out _);

            var room = new Room(roomId);
            loadedRooms.TryAdd(roomId, room);

            throw new NotImplementedException();

            // return new ValueTask<IRoom>(room);
        }
    }
}
