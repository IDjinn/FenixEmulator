using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Outgoing
{
   public interface IOutgoingPacket : IDisposable
    {
        public int Id { get; init; }
        public List<byte> Buffer { get; }
        public int Pointer { get; }
        public IOutgoingPacket WriteBoolean(bool value);
        public IOutgoingPacket WriteSByte(sbyte value);
        public IOutgoingPacket WriteByte(byte value);
        public IOutgoingPacket WriteShort(short value);
        public IOutgoingPacket WriteInt(int value);
        public IOutgoingPacket WriteUInt(uint value);
        public IOutgoingPacket WriteLong(long value);
        public IOutgoingPacket WriteULong(ulong value);
        public IOutgoingPacket WriteFloat(float value);
        public IOutgoingPacket WriteDouble(double value);
        public IOutgoingPacket WriteString(string value);
        public IOutgoingPacket WriteByteArray(byte[] bytes);
        public IOutgoingPacket WriteByteArray(byte[] bytes, int length);
        public IOutgoingPacket WriteByteArray(byte[] bytes, int offset, int length);
        public IOutgoingPacket WriteByte(ReadOnlyMemory<byte> value);
        public IOutgoingPacket WriteByte(ReadOnlySpan<byte> value);
    }
}
