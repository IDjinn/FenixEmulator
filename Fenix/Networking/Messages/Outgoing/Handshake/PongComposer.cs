using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Outgoing.Handshake
{
    public class PongComposer : OutgoingPacket
    {
        public PongComposer(int value) : base(OutgoingPacketsHeader.PongComposer) => Write(value);
    }
}
