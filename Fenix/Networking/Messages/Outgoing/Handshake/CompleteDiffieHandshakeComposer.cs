namespace Server.Networking.Messages.Outgoing.Handshake
{
    class CompleteDiffieHandshakeComposer : OutgoingPacket
    {
        public CompleteDiffieHandshakeComposer(string key) : base(OutgoingPacketsHeader.CompleteDiffieHandshakeComposer)
        {
            Write(key);
        }
    }
}
