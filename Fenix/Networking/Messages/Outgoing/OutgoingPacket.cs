using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Outgoing
{
    public class OutgoingPacket : IOutgoingPacket
    {
        private bool disposedValue;
        public int Id { get; init; }
        public List<byte> Buffer { get; private set; }
        public int Pointer { get; private set; } = 0;

        public OutgoingPacket(int Id)
        {
            this.Id = Id;
            Buffer = new List<byte>();
        }

        public IOutgoingPacket WriteBoolean(bool value)
        {
            Buffer[Pointer++] = value ? 1 : 0;
            return this;
        }

        public IOutgoingPacket WriteSByte(sbyte value)
        {
            Buffer[Pointer++] = (byte)value;
            return this;
        }

        public IOutgoingPacket WriteByte(byte value)
        {
            Buffer[Pointer++] = value;
            return this;
        }

        public IOutgoingPacket WriteShort(short value)
        {
            Buffer[Pointer++] = (byte)value;
            Buffer[Pointer++] = (byte)(value >> 8);
            return this;
        }

        public IOutgoingPacket WriteInt(int value)
        {
            Buffer[Pointer++] = (byte)value;
            Buffer[Pointer++] = (byte)(value >> 8);
            Buffer[Pointer++] = (byte)(value >> 16);
            Buffer[Pointer++] = (byte)(value >> 24);
            return this;
        }

        public IOutgoingPacket WriteUInt(uint value)
        {
            Buffer[Pointer++] = (byte)value;
            Buffer[Pointer++] = (byte)(value >> 8);
            Buffer[Pointer++] = (byte)(value >> 16);
            Buffer[Pointer++] = (byte)(value >> 24);
            return this;
        }

        public IOutgoingPacket WriteLong(long value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(long);
            return this;
        }

        public IOutgoingPacket WriteULong(ulong value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(ulong);
            return this;
        }

        public IOutgoingPacket WriteFloat(float value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(float);
            return this;
        }

        public IOutgoingPacket WriteDouble(double value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(double);
            return this;
        }

        public IOutgoingPacket WriteString(string value)
        {
            WriteInt(value.Length);
            WriteByteArray(Encoding.ASCII.GetBytes(value));
            return this;
        }

        public IOutgoingPacket WriteByteArray(byte[] bytes)
        {
            int index = 0;

            do Buffer[index] = bytes[index];
            while (index < bytes.Length);

            Pointer += index;
            return this;
        }

        public IOutgoingPacket WriteByteArray(byte[] bytes, int length)
        {
            throw new NotImplementedException();
        }

        public IOutgoingPacket WriteByteArray(byte[] bytes, int offset, int length)
        {
            throw new NotImplementedException();
        }

        public IOutgoingPacket WriteByte(ReadOnlyMemory<byte> value)
        {
            throw new NotImplementedException();
        }

        public IOutgoingPacket WriteByte(ReadOnlySpan<byte> value)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
#pragma warning disable CS8625 // Não é possível converter um literal nulo em um tipo de referência não anulável.
                    Buffer = null;
#pragma warning restore CS8625 // Não é possível converter um literal nulo em um tipo de referência não anulável.
                }
                disposedValue = true;
            }
        }

        ~OutgoingPacket()
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
