using System;

using Api.Hotel.Habbos;
using Api.Networking.Messages.Outgoing;

namespace Api.Networking.Clients
{
    public interface IClient : IDisposable
    {
        public Guid ConnectionId { get; init; }
        public bool IsAuthentificated { get; }
        public object? ARC4 { get; }
        public string? SSO { get; }
        public IHabbo? Habbo { get; }
        public void Init();
        public void SetHabbo(IHabbo? habbo);
        public void SetSSO(string? SSO);

        public void Send(IOutgoingPacket packet);
        public void Send(byte[] bytes);
        public void Send(ReadOnlyMemory<byte> bytes);
        public void SetARC4(object? arc4);
    }
}
