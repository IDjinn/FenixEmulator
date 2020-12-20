using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Hotel.Rooms.Units.Util
{
    public interface IUnitIdleable
    {
        public long IdleTimestamp { get; }
        public bool IsIdle { get; }
        public void StartIdle(long value);
        public void StopIdle();
    }
}
