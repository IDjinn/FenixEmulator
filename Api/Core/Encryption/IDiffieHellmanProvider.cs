using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Encryption
{
    public interface IDiffieHellmanProvider
    {
        public string GetRsaDiffieHellmanPrimeKey();
        public string GetRsaDiffieHellmanGeneratorKey();
    }
}
