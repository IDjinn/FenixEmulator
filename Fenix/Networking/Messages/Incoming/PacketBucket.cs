using Api.Networking.Messages.Incoming;

namespace Server.Networking.Messages.Incoming
{
    public struct PacketBucket : IPacketBucket
    {
        public int Tokens { get; set; }
        public long ResetBucketAt { get; init; }

        public PacketBucket(int tokens, long resetBucketAt) => (Tokens, ResetBucketAt) = (tokens, resetBucketAt);
        public PacketBucket(IPacketBucket bucket) => (Tokens, ResetBucketAt) = (bucket.Tokens, bucket.ResetBucketAt);
    }
}
