using Api.Hotel.Rooms;
using Api.Hotel.Rooms.Info;

namespace Api.Util.Factories.Hotel.Rooms
{
    public interface IRoomFactory
    {
        public IRoom Create(IRoomInfo roomInfo);
    }
}
