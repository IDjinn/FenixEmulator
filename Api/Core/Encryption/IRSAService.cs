using System.Security.Cryptography;

namespace Api.Core.Encryption
{
    public interface IRSAService
    {
        public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding);
        public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding);
    }
}
