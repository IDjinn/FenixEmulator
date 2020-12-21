using Fenix.Hotel.Habbos;
using Fenix.Networking.Messages;
using Fenix.Networking.Messages.Incoming;
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

        public Client(Socket socket)
        {
            ConnectionId = Guid.NewGuid();
            this.socket = socket;
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
                    throw new ArgumentNullException(nameof(packet), "Packet cannot be null");

                int bytesRead = socket.EndReceive(asyncResult);
                if (bytesRead > 0)
                {
                    int id = packet.ReadInt();
                    Console.WriteLine($"Id {id} packet {BitConverter.ToString(packet.Buffer)}");

                       // int readsize = (SocketManager.BUFFER_SIZE > size) ? size : SocketManager.BUFFER_SIZE;
                        //packet.Socket.BeginReceive(packet.Buffer, packet.ReaderPointer, readsize, SocketFlags.None, new AsyncCallback(recieveCallback), packet);
                }
            }
            catch
            {
                //log("Error recieving Message!");
                //closeClient();
                throw new Exception();
            }
        }

        public void Send(IIncomingPacket packet)
        {
            try
            {
                socket.BeginSend(packet.Buffer, 0, packet.Buffer.Length, SocketFlags.None, out SocketError errorCode, new AsyncCallback(SendCallback), packet);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ", e.ToString());
            }
        }


        private void SendCallback(IAsyncResult asyncResult)
        {
            try
            {
                using IIncomingPacket? packet = asyncResult.AsyncState as IIncomingPacket;
                if (packet is not IIncomingPacket)
                    throw new ArgumentNullException(nameof(packet), "Packet must not be null");

                int bytesSent = socket.EndSend(asyncResult);
                Console.WriteLine("Bytes sent: " + bytesSent + " of " + packet.Buffer.Length + 4);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ", e.ToString());
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
