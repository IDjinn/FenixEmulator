using Fenix.Hotel.Habbos;
using Fenix.Networking.Messages;
using Fenix.Networking.Messages.Incoming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking
{
    public interface IClient : IDisposable
    {
        public Guid ConnectionId { get; init; }
        public bool IsAuthentificated { get; }
        public string? SSO { get; }
        public IHabbo? Habbo { get; }
        public void Init();
        public void Send(IIncomingPacket packet);
        public void SetHabbo(IHabbo? habbo);
        public void SetSSO(string? SSO);
    }
}
