using Server.Core.Encryption.Crypto.RSA;
using Server.Core.Encryption.KeyExchange;
using Server.Util;
using Server.Util.String;
using System;
using System.Text;

namespace Server.Core.Encryption
{
    public static class HabboEncryptionV2
    {
        private static RSAKey Rsa = RSAKey.ParsePrivateKey(Constants.RSA_N, Constants.RSA_E, Constants.RSA_D);
        private static DiffieHellman DiffieHellman = new();


        private static string GetRsaStringEncrypted(string message)
        {
            try
            {
                byte[] m = Encoding.Default.GetBytes(message);
                byte[] c = Rsa.Sign(m);

                return StringUtils.UnsafeByteArrayToString(c);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static string GetRsaDiffieHellmanPrimeKey()
        {
            string key = DiffieHellman.Prime.ToString(10);
            return GetRsaStringEncrypted(key);
        }

        public static string GetRsaDiffieHellmanGeneratorKey()
        {
            string key = DiffieHellman.Generator.ToString(10);
            return GetRsaStringEncrypted(key);
        }

        public static string GetRsaDiffieHellmanPublicKey()
        {
            string key = DiffieHellman.PublicKey.ToString(10);
            return GetRsaStringEncrypted(key);
        }

        public static BigInteger CalculateDiffieHellmanSharedKey(string publicKey)
        {
            try
            {
                byte[] cbytes = StringUtils.HexStringToByteArray(publicKey);
                byte[] publicKeyBytes = Rsa.Verify(cbytes);
                string publicKeyString = Encoding.Default.GetString(publicKeyBytes);
                return DiffieHellman.CalculateSharedKey(new BigInteger(publicKeyString, 10));
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
