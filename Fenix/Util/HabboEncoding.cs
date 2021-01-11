namespace Serbyteser.Util
{
    public static class HabboEncoding
    {
        public static int DecodeInt(byte[] bytes)
        {
            if ((bytes[0] | bytes[1] | bytes[2] | bytes[3]) < 0)
                return -1;
            return (bytes[0] << 0x18) + (bytes[1] << 0x10) + (bytes[2] << 8) + bytes[3];
        }

        public static short DecodeShort(byte[] bytes)
        {
            if ((bytes[0] | bytes[1]) < 0)
                return -1;
            return (short)((bytes[0] << 8) + bytes[1]);
        }
    }
}
