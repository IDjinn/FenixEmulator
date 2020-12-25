using Fenix.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Util.Interfaces
{
    public interface IPacketSerializable
    {
        public IOutgoingPacket Serializable(IOutgoingPacket? packet = null);
    }
}
