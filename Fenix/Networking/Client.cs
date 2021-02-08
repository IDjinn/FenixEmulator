using Api.Hotel.Habbos;
using Api.Networking;
using Api.Networking.Clients;
using Api.Networking.Messages.Incoming;
using Api.Networking.Messages.Outgoing;
using Microsoft.Extensions.Logging;
using Server.Core.Encryption.Crypto.Prng;
using Server.Networking.Messages.Incoming;
using System;
using System.Net.Sockets;

namespace Server.Networking
{
    public class Client : IClient
    {
        private bool disposedValue;
        public Guid ConnectionId { get; init; }
        private Socket socket { get; init; }
        public object? ARC4 { get; private set; }
        public string? SSO { get; private set; }
        public IHabbo? Habbo { get; private set; }
        public bool IsAuthentificated { get; private set; } = false;
        private ISocketManager socketManager { get; init; }
        private IPacketManager packetManager { get; init; }
        private ILogger<IClient> logger { get; init; }

        public Client(ILogger<IClient> logger, ISocketManager socketManager, IPacketManager packetManager, Socket socket)
        {
            ConnectionId = Guid.NewGuid();
            this.logger = logger;
            this.socketManager = socketManager;
            this.packetManager = packetManager;
            this.socket = socket;
        }

        public void Init()
        {
            using IIncomingPacket packet = new IncomingPacket(SocketManager.BUFFER_SIZE);
            socket.BeginReceive(packet.Buffer, 0, packet.Buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallback), packet);
        }

        private void RecieveCallback(IAsyncResult asyncResult)
        {
            try
            {
                using IIncomingPacket? packet = asyncResult.AsyncState as IIncomingPacket;
                if (packet is not IIncomingPacket)
                    throw new ArgumentException(nameof(packet), "Packet muste be typeof IIncomingPacket");

                int bytesRead = socket.EndReceive(asyncResult);

                if (bytesRead > 0)
                {
                    if (ARC4 is ARC4 arc4)
                    {
                        //arc4.Decrypt(ref packet.Buffer);
                    }
                    packet.Init();
                    packetManager.HandlePacket(this, packet);
                }

                packet.Clear();
                socket.BeginReceive(packet.Buffer, 0, packet.Buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallback), packet);
            }
            catch (ArgumentException argException)
            {
                logger.LogError(argException.Message, argException);
            }
            catch (ObjectDisposedException disposedException)
            {
                logger.LogWarning("Socket was disposed.", disposedException);
            }
            catch (SocketException socketException)
            {
                logger.LogError(socketException.Message, socketException);
            }
            catch (InvalidOperationException invalidOperationException)
            {
                logger.LogError(invalidOperationException.Message, invalidOperationException);
            }
        }

        public void Send(IOutgoingPacket packet)
        {
            logger.LogInformation($"Id {packet.Id} outgoing");
            Send(packet.GetBytes());
        }

        public void Send(byte[] bytes)
        {
            try
            {
                logger.LogInformation($"Bytes {bytes.Length} size sending");
                socket.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, out SocketError errorCode, new AsyncCallback(SendCallback), null);
            }
            catch (ObjectDisposedException disposedException)
            {
                logger.LogWarning("Socket was disposed.", disposedException);
            }
            catch (SocketException socketException)
            {
                logger.LogError(socketException.Message, socketException);
            }
        }



        private void SendCallback(IAsyncResult asyncResult)
        {
            try
            {
                using IOutgoingPacket? packet = asyncResult.AsyncState as IOutgoingPacket;
                int bytesSent = socket.EndSend(asyncResult);

                if (packet is null)
                    return;

                if (packet is not IIncomingPacket)
                    throw new ArgumentException(nameof(packet), "Packet muste be typeof IIncomingPacket");

                Console.WriteLine("Bytes sent: " + bytesSent + " of " + packet.GetBytes().Length);
            }
            catch (ArgumentException argException)
            {
                logger.LogError(argException.Message, argException);
            }
            catch (ObjectDisposedException disposedException)
            {
                logger.LogWarning("Socket was disposed.", disposedException);
            }
            catch (SocketException socketException)
            {
                logger.LogError(socketException.Message, socketException);
            }
            catch (InvalidOperationException invalidOperationException)
            {
                logger.LogError(invalidOperationException.Message, invalidOperationException);
            }
        }

        public void SetHabbo(IHabbo? habbo)
        {
            Habbo = habbo;
        }

        public void SetSSO(string? SSO)
        {
            IsAuthentificated = string.IsNullOrWhiteSpace(SSO) is false;
            this.SSO = SSO;
        }

        public void SetARC4(object? arc4)
        {
            ARC4 = arc4;
        }

        public void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    socket.Dispose();
                    SetHabbo(null);
                    SetSSO(null);
                }

                disposedValue = true;
            }
        }

        ~Client()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void Send(ReadOnlyMemory<byte> bytes)
        {
            Send(bytes.ToArray());
        }
    }
}
