namespace Api.Core.Encryption
{
    public interface IDiffieHellmanProvider
    {
        public string GetRsaDiffieHellmanPrimeKey();
        public string GetRsaDiffieHellmanGeneratorKey();
    }
}
