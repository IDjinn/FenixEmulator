namespace Server.Networking.Messages.Outgoing.Handshake
{
    class InitDiffieHandshakeComposer : OutgoingPacket
    {
        public InitDiffieHandshakeComposer(string prime, string generator) : base(OutgoingPacketsHeader.InitDiffieHandshakeComposer)
        {
            Write(prime);
            Write(generator);
        }
    }
}
