using System;

namespace Api.Networking.Messages.Outgoing
{
    public interface IOutgoingPacket : IDisposable
    {
        public short Id { get; init; }
        public int Pointer { get; }
        public byte[] GetBytes();
        public IOutgoingPacket Write(bool value);
        public IOutgoingPacket Write(sbyte value);
        public IOutgoingPacket Write(byte value);
        public IOutgoingPacket Write(short value);
        public IOutgoingPacket Write(int value);
        public IOutgoingPacket Write(uint value);
        public IOutgoingPacket Write(long value);
        public IOutgoingPacket Write(ulong value);
        public IOutgoingPacket Write(float value);
        public IOutgoingPacket Write(double value);
        public IOutgoingPacket Write(string value);
        public IOutgoingPacket WriteByteArray(byte[] bytes);
        public IOutgoingPacket WriteByteArray(byte[] bytes, int length);
        public IOutgoingPacket WriteByteArray(byte[] bytes, int offset, int length);
        public IOutgoingPacket WriteByte(ReadOnlyMemory<byte> value);
        public IOutgoingPacket WriteByte(ReadOnlySpan<byte> value);
    }
}
