using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Api.Core.Encryption;

namespace Server.Core.Encryption
{
    public class DiffieHellmanProvider :IDiffieHellmanProvider
    {
        public DiffieHellmanProvider()
        {

        }

        public string GetRsaDiffieHellmanPrimeKey()
        {
            //string key = DiffieHellmanProvider.Prime.ToString(10);
            //return GetRsaStringEncrypted(key);
            return "";
        }

        public string GetRsaDiffieHellmanGeneratorKey()
        {
            //string key = DiffieHellmanProvider.Generator.ToString(10);
            //return GetRsaStringEncrypted(key);
            return "";
        }
    }
}
