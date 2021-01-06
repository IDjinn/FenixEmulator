using System;

using Api.Networking.Messages.Incoming;

using Server.Util;

namespace Server.Networking.Messages.Incoming
{
    public class IncomingPacket : IIncomingPacket
    {
        private bool IsDisposed;
        public int Id { get; private set; }
        public byte[] Buffer { get; init; }
        public int Pointer { get; private set; } = 0;
        public int AvailableBytes => Buffer.Length - Pointer;

        public IncomingPacket(int BufferSize)
        {
            Buffer = new byte[BufferSize];
            //int _ = ReadInt();//message size
        }

        public void Init()
        {
            Pointer += sizeof(int);
            Id = (Buffer[Pointer++] << 8) + Buffer[Pointer++];//ReadShort();
        }

        public byte ReadByte()
        {
            return Buffer[Pointer++];
        }

        public byte[] ReadBytes(int length)
        {
            byte[] bytes = new byte[length];
            Array.Copy(Buffer, bytes, length);
            Pointer += length;
            return bytes;
        }

        public double ReadDouble()
        {
            double value = BitConverter.ToDouble(Buffer, Pointer);
            Pointer += sizeof(double);
            return value;
        }

        public float ReadFloat()
        {
            float value = BitConverter.ToSingle(Buffer, Pointer);
            Pointer += sizeof(float);
            return value;
        }

        public int ReadInt()
        {
            return Buffer[Pointer++] << 24 +
                Buffer[Pointer++] << 16 +
                Buffer[Pointer++] << 8 +
                Buffer[Pointer++];
        }

        public long ReadLong()
        {
            int value = BitConverter.ToInt32(Buffer, Pointer);
            Pointer += sizeof(int);
            return value;
        }

        public sbyte ReadSByte()
        {
            return (sbyte)ReadByte();
        }

        public short ReadShort()
        {
            return (short)(Buffer[Pointer++] << 8 + Buffer[Pointer++]);
        }

        public string ReadString()
        {
            int length = ReadShort();
            string value = BitConverter.ToString(Buffer, Pointer, length);
            Pointer += length;
            return value;
        }

        public uint ReadUInt()
        {
            uint value = BitConverter.ToUInt32(Buffer, Pointer);
            Pointer += sizeof(uint);
            return value;
        }

        public ulong ReadULong()
        {
            ulong value = BitConverter.ToUInt64(Buffer, Pointer);
            Pointer += sizeof(ulong);
            return value;
        }

        public ushort ReadUShort()
        {
            ushort value = BitConverter.ToUInt16(Buffer, Pointer);
            Pointer += sizeof(ushort);
            return value;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                   // Buffer = null;
                }
                IsDisposed = true;
            }
        }

        ~IncomingPacket()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}