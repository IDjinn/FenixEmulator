namespace Server.Networking.Messages.Outgoing.Handshake
{
    public class PongComposer : OutgoingPacket
    {
        public PongComposer(int value) : base(OutgoingPacketsHeader.PongComposer) => Write(value);
    }
}
