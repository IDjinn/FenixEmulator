namespace Api.Networking.Messages.Incoming
{
    public interface IPacketBucket
    {
        public ushort Tokens { get; }
        public long ResetBucketAt { get; init; }
    }
}