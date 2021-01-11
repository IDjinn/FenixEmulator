using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Server.Util.String
{
    public unsafe partial class StringUtils
    {
        // thank you, https://stackoverflow.com/questions/311165/how-do-you-convert-a-byte-array-to-a-hexadecimal-string-and-vice-versa/624379#624379
        static readonly uint* _lookup32UnsafeP = (uint*)GCHandle.Alloc(_Lookup32, GCHandleType.Pinned).AddrOfPinnedObject();
        public static string UnsafeByteArrayToString(byte[] bytes)
        {
            var lookupP = _lookup32UnsafeP;
            var result = new string((char)0, bytes.Length * 2);
            fixed (byte* bytesP = bytes)
            fixed (char* resultP = result)
            {
                uint* resultP2 = (uint*)resultP;
                for (int i = 0; i < bytes.Length; i++)
                {
                    resultP2[i] = lookupP[bytesP[i]];
                }
            }
            return result;
        }

        static uint[] _Lookup32 = Enumerable.Range(0, 255).Select(i =>
        {
            string s = i.ToString("X2");
            return s[0] + ((uint)s[1] << 16);
        }).ToArray();

        // thank you, https://stackoverflow.com/questions/14332496/most-light-weight-conversion-from-hex-to-byte-in-c
        public static byte[] HexStringToByteArray(string hexString)
        {
            if ((hexString.Length & 1) != 0)
            {
                throw new ArgumentException("Input must have even number of characters");
            }

            byte[] ret = new byte[hexString.Length / 2];
            for (int i = 0; i < ret.Length; i++)
            {
                int high = ParseNybble(hexString[i * 2]);
                int low = ParseNybble(hexString[i * 2 + 1]);
                ret[i] = (byte)((high << 4) | low);
            }

            return ret;
        }

        private static int ParseNybble(char c)
        {
            unchecked
            {
                uint i = (uint)(c - '0');
                if (i < 10)
                    return (int)i;
                i = ((uint)c & ~0x20u) - 'A';
                if (i < 6)
                    return (int)i + 10;
                throw new ArgumentException("Invalid nybble: " + c);
            }
        }
    }
}
