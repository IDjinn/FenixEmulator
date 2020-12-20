using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming
{
    public class IncomingPacket : IIncomingPacket
    {
        private bool IsDisposed;
        public int Id { get; init; }
        public byte[] Buffer { get; private set; }
        public int Pointer { get; private set; } = 0;

        public IncomingPacket(byte[] Buffer)
        {
            this.Buffer = Buffer;
            Id = ReadInt();
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
            int value = BitConverter.ToInt32(Buffer, Pointer);
            Pointer += sizeof(int);
            return value;
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
            short value = BitConverter.ToInt16(Buffer, Pointer);
            Pointer += sizeof(short);
            return value;
        }

        public string ReadString()
        {
            int length = ReadInt();
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
#pragma warning disable CS8625 // Não é possível converter um literal nulo em um tipo de referência não anulável.
                    Buffer = null;
#pragma warning restore CS8625 // Não é possível converter um literal nulo em um tipo de referência não anulável.
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