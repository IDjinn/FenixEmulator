using System;

namespace Api.Networking.Messages.Incoming
{
    public interface IIncomingPacket : IDisposable
    {
        public ushort Id { get; }
        public byte[] Buffer { get; }
        public int Pointer { get; }
        public int Size { get; }
        public int AvailableBytes { get; }
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
        public void Clear();
        public void Init();
    }
}
