using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Encryption
{
    public interface IRSAService
    {
        public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding);
        public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding);
    }
}
