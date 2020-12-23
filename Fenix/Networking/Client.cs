using Fenix.Hotel.Habbos;
using Fenix.Networking.Messages;
using Fenix.Networking.Messages.Incoming;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking
{
    public sealed class Client : IClient
    {
        private bool disposedValue;
        public Guid ConnectionId { get; init; }
        private Socket socket { get; init; }
        public string? SSO { get; private set; }
        public IHabbo? Habbo { get; private set; }
        public bool IsAuthentificated { get; private set; } = false;
        private ISocketManager socketManager { get; init; }
        private ILogger logger = NullLogger.Instance;

        public Client(ISocketManager socketManager, Socket socket)
        {
            ConnectionId = Guid.NewGuid();
            this.socket = socket;
            this.socketManager = socketManager;
        }

        public void Init()
        {
            using IIncomingPacket packet = new IncomingPacket(SocketManager.BUFFER_SIZE);
            socket.BeginReceive(packet.Buffer, 0, packet.Buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallback), socket);
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
                    ushort id = packet.ReadUShort();
                    logger.LogInformation($"Id {id} packet {BitConverter.ToString(packet.Buffer)}");
                }
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

        public void Send(IIncomingPacket packet)
        {
            try
            {
                socket.BeginSend(packet.Buffer, 0, packet.Buffer.Length, SocketFlags.None, out SocketError errorCode, new AsyncCallback(SendCallback), packet);

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
                using IIncomingPacket? packet = asyncResult.AsyncState as IIncomingPacket;
                if (packet is not IIncomingPacket)
                    throw new ArgumentException(nameof(packet), "Packet muste be typeof IIncomingPacket");

                int bytesSent = socket.EndSend(asyncResult);
                Console.WriteLine("Bytes sent: " + bytesSent + " of " + packet.Buffer.Length + 4);
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
            IsAuthentificated = habbo is IHabbo;
            Habbo = habbo;
        }

        public void SetSSO(string? SSO)
        {
            this.SSO = SSO;
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
    }
}
