namespace Api.Networking
{
    public interface ISocketManager
    {
        public static int PORT { get; }
        public static int BUFFER_SIZE { get; }
        public static int MAX_QUEUE_CONNECTIONS { get; }
        public static int MAX_CONNECTIONS { get; }
        public void StartListener();
        public void StopListener();
    }
}
