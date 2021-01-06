using Api.Networking.Messages.Outgoing;

namespace Api.Util.Interfaces
{
    public interface IPacketSerializable
    {
        public IOutgoingPacket Serializable(IOutgoingPacket? packet = null);
    }
}
