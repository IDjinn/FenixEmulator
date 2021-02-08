using Api.Networking.Messages.Outgoing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Networking.Messages.Outgoing
{
    public class OutgoingPacket : IOutgoingPacket
    {
        private bool disposedValue;
        public short Id { get; init; }
        private List<byte> Buffer { get; init; }
        public int Pointer { get; private set; } = 0;

        public OutgoingPacket(short Id)
        {
            this.Id = Id;
            Buffer = new List<byte>();
            Write(Id);
        }

        public byte[] GetBytes()
        {
            var copy = new List<byte>();
            copy.AddRange(BitConverter.GetBytes(Buffer.Count));
            copy.Reverse();
            copy.AddRange(Buffer);
            return copy.ToArray();
        }

        public IOutgoingPacket Write(bool value)
        {
            Buffer.Add(value ? 1 : 0);
            return this;
        }

        public IOutgoingPacket Write(sbyte value)
        {
            Buffer.Add((byte)value);
            return this;
        }

        public IOutgoingPacket Write(byte value)
        {
            Buffer.Add(value);
            return this;
        }

        public IOutgoingPacket Write(short value)
        {
            Buffer.Add((byte)value);
            Buffer.Add((byte)(value >> 8));
            return this;
        }

        public IOutgoingPacket Write(int value)
        {
            Buffer.Add((byte)value);
            Buffer.Add((byte)(value >> 8));
            Buffer.Add((byte)(value >> 16));
            Buffer.Add((byte)(value >> 24));
            return this;
        }

        public IOutgoingPacket Write(uint value)
        {
            Buffer.Add((byte)value);
            Buffer.Add((byte)(value >> 8));
            Buffer.Add((byte)(value >> 16));
            Buffer.Add((byte)(value >> 24));
            return this;
        }

        public IOutgoingPacket Write(long value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(long);
            return this;
        }

        public IOutgoingPacket Write(ulong value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(ulong);
            return this;
        }

        public IOutgoingPacket Write(float value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(float);
            return this;
        }

        public IOutgoingPacket Write(double value)
        {
            WriteByteArray(BitConverter.GetBytes(value));
            Pointer += sizeof(double);
            return this;
        }

        public IOutgoingPacket Write(string value)
        {
            Write(value.Length);
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
                    Buffer.Clear();
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
