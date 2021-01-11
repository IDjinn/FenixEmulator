using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

using Api.Networking;
using Api.Networking.Clients;
using Api.Util.Factories.Networking;

using Microsoft.Extensions.Logging;

namespace Server.Networking
{
    class SocketManager : ISocketManager
    {
        public static int PORT { get; private set; }
        public static int BUFFER_SIZE { get; private set; }
        public static int MAX_QUEUE_CONNECTIONS { get; private set; }
        public static int MAX_CONNECTIONS { get; private set; }
        private Socket socket { get; init; }
        private ConcurrentDictionary<Guid, IClient> clients { get; init; }
        private ILogger<ISocketManager> logger { get; init; }
        private IClientFactory clientFactory { get; init; }

        public SocketManager(ILogger<ISocketManager> logger, IClientFactory clientFactory, int? port = null, int? bufferSize = null, int? maxQueueConnections = null, int? maxConnections = null)
        {
            this.logger = logger;
            this.clientFactory = clientFactory;
            PORT = port ?? 100;
            BUFFER_SIZE = bufferSize ?? 1024;
            MAX_QUEUE_CONNECTIONS = maxQueueConnections ?? 20;
            MAX_CONNECTIONS = maxConnections ?? 100;

            socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clients = new ConcurrentDictionary<Guid, IClient>();
        }

        public void StartListener()
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            socket.Listen(MAX_QUEUE_CONNECTIONS);
            socket.BeginAccept(new AsyncCallback(AcceptCallback), null);

            logger.LogInformation($"Listening at {PORT}");
        }

        public void StopListener()
        {
            socket.Dispose();
            logger.LogInformation("Socket stoped");
        }

        private void AcceptCallback(IAsyncResult asyncResult)
        {
            try
            {
                Socket? clientSocket = socket.EndAccept(asyncResult);
                if (clientSocket is not Socket)
                {
                    throw new ArgumentNullException(nameof(clientSocket), "Client socket cannot be null");
                }

                socket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                logger.LogInformation($"Connection from {clientSocket.RemoteEndPoint!.ToString() ?? "unknow endpoint"} recieved.");

                if (clients.Count >= MAX_CONNECTIONS)
                {
                    logger.LogInformation($"Max Number of Clients connected is reached. IP: {clientSocket.RemoteEndPoint!.ToString() ?? "unknown endpoint"} got declined.");
                    clientSocket.Close();
                    return;
                }

                var client = clientFactory.Create(clientSocket);
                if (clients.TryAdd(client.ConnectionId, client))
                {
                    client.Init();
                }
                else
                {
                    logger.LogInformation($"Client {client.ConnectionId} cannot be put into clients dict.");
                    return;
                }
            }
            catch (Exception e)
            {
                logger.LogError("Error accepting connection!", e);
            }
        }
    }
}
