using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Api.Core.Encryption;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;

namespace Server.Core.Encryption
{
    public class RSAService : IRSAService
    {
        private ILogger<IRSAService> logger;
        public RSAService(ILogger<IRSAService> logger)
        {
            this.logger = logger;
        }

        public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                logger.LogError($"Error while encrypt: {e}");
                return Array.Empty<byte>();
            }
        }

        public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                logger.LogError($"Error while decrypt: {e}");
                return Array.Empty<byte>();
            }
        }
    }
}
