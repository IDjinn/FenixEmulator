using Fenix.Networking.Messages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Networking
{
    class SocketManager : ISocketManager, IServiceProvider
    {
        public static int PORT { get; private set; }
        public static int BUFFER_SIZE { get; private set; }
        public static int MAX_QUEUE_CONNECTIONS { get; private set; }
        public static int MAX_CONNECTIONS { get; private set; }
        private Socket socket { get; init; }
        private ConcurrentDictionary<Guid, Client> clients { get; init; }
        private ILogger<ISocketManager> logger { get; init; }
        private IServiceCollection services { get; init; }
        private IServiceProvider provider { get; init; }

        public SocketManager(ILogger<ISocketManager> logger, int port = 100, int? bufferSize = null, int? maxQueueConnections = null, int? maxConnections = null)
        {
            this.logger = logger;
            PORT = port;
            BUFFER_SIZE = bufferSize ?? 1024;
            MAX_QUEUE_CONNECTIONS = maxQueueConnections ?? 20;
            MAX_CONNECTIONS = maxConnections ?? 100;

            socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clients = new ConcurrentDictionary<Guid, Client>();

            services = new ServiceCollection();
            services.AddLogging();

            provider = services.BuildServiceProvider();

            this.StartListener();
        }

        public void StartListener()
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            socket.Listen(MAX_QUEUE_CONNECTIONS);
            socket.BeginAccept(new AsyncCallback(AcceptCallback), socket);
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
                Socket? serverSocket = asyncResult.AsyncState as Socket;
                if (serverSocket is not Socket)
                {
                    throw new ArgumentNullException(nameof(serverSocket), "Server socket cannot be null");
                }

                Socket? clientSocket = serverSocket.EndAccept(asyncResult);
                if (clientSocket is not Socket)
                {
                    throw new ArgumentNullException(nameof(clientSocket), "Client socket cannot be null");
                }

                serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), serverSocket);

                logger.LogInformation($"Connection from {clientSocket.RemoteEndPoint!.ToString() ?? "unknow endpoint"} recieved.");

                if (MAX_CONNECTIONS >= clients.Count)
                {
                    clientSocket.Close();
                    logger.LogInformation($"Max Number of Clients connected is reached. IP: {clientSocket.RemoteEndPoint!.ToString() ?? "unknown endpoint"} got declined.");
                    return;
                }

                var client = new Client(this, clientSocket);
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
            catch
            {
                logger.LogInformation("Error accepting connection!");
            }
        }

        public object? GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
