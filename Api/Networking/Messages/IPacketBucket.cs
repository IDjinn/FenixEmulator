namespace Api.Networking.Messages.Incoming
{
    public interface IPacketBucket
    {
        public int Tokens { get; set; }
        public long ResetBucketAt { get; init; }
    }
}