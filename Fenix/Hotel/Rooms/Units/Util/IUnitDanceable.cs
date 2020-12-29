using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Hotel.Rooms.Units.Util
{
    public interface IUnitDanceable
    {
        public byte DanceId { get; }
        public bool IsDancing { get; }
        public void StartDance(byte danceId);
        public void StopDance();
    }
}
