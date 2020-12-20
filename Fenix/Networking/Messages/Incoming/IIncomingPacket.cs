using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Networking.Messages.Incoming
{
    public interface IIncomingPacket : IDisposable
    {
        public int Id { get; init; }
        public byte[] Buffer { get; }
        public int Pointer { get; }
        public sbyte ReadSByte();
        public byte ReadByte();
        public short ReadShort();
        public ushort ReadUShort();
        public int ReadInt();
        public uint ReadUInt();
        public long ReadLong();
        public ulong ReadULong();
        public string ReadString();
        public float ReadFloat();
        public double ReadDouble();
        public byte[] ReadBytes(int length);
    }
}
