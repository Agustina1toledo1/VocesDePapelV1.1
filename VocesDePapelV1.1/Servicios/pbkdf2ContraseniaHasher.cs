using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace VocesDePapelV1._1.Servicios
{
    public class pbkdf2ContraseniaHasher : IContraseniaHasher
    {
        private const int Iterations = 100_000;
        private const int SaltSize = 16; // bytes
        private const int HashSize = 32; // bytes
        public string Hash(string contraseniaPlana)
        {
            // 1. Generar salt aleatorio
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            // 2. Derivar el hash
            using var pbkdf2 = new Rfc2898DeriveBytes(
              contraseniaPlana, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // 3. Combinar salt + hash y codificar en Base64
            byte[] combo = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, combo, 0, SaltSize);
            Array.Copy(hash, 0, combo, SaltSize, HashSize);

            return Convert.ToBase64String(combo);
        }

        public bool Verify(string contraseniaPlana, string almacenaHash)
        {
            byte[] combo = Convert.FromBase64String(almacenaHash);

            // 1. Extraer salt
            byte[] salt = new byte[SaltSize];
            Array.Copy(combo, 0, salt, 0, SaltSize);

            // 2. Derivar hash con el mismo salt
            using var pbkdf2 = new Rfc2898DeriveBytes(
              contraseniaPlana, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] hashToTest = pbkdf2.GetBytes(HashSize);

            // 3. Extraer el hash original y comparar en tiempo constante
            byte[] originalHash = new byte[HashSize];
            Array.Copy(combo, SaltSize, originalHash, 0, HashSize);

            return CryptographicOperations.FixedTimeEquals(originalHash, hashToTest);
        }
    }
}
