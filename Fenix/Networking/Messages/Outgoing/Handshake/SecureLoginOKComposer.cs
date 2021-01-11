namespace Server.Networking.Messages.Outgoing.Handshake
{
    class SecureLoginOKComposer : OutgoingPacket
    {
        public SecureLoginOKComposer() : base(OutgoingPacketsHeader.SecureLoginOKComposer) { }
    }
}
