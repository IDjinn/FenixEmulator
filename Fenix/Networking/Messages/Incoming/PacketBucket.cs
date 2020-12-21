using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming
{
    struct PacketBucket : IPacketBucket
    {
        public ushort Tokens { get; private set; }
        public long ResetBucketAt { get; init; }

        public PacketBucket(ushort tokens, long resetBucketAt) => (Tokens, ResetBucketAt) = (tokens, resetBucketAt);
        public PacketBucket(IPacketBucket bucket) => (Tokens, ResetBucketAt) = (bucket.Tokens, bucket.ResetBucketAt);
    }
}
