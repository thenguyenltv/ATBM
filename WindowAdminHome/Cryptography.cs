using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace WindowAdminHome
{
    internal class RSA
    {
        private RSACryptoServiceProvider rsa;

        public RSA(int keySize)
        {
            rsa = new RSACryptoServiceProvider(keySize);
        }

        public string GetPublicKey()
        {
            RSAParameters publicKey = rsa.ExportParameters(false);
            string publicKeyXml = rsa.ToXmlString(false);
            return publicKeyXml;
        }

        public void ExportPrivateKeyToFile(string fileName)
        {
            RSAParameters privateKey = rsa.ExportParameters(true);
            string privateKeyXml = rsa.ToXmlString(true);
            File.WriteAllText(fileName, privateKeyXml);
        }

        public int ImportPrivateKeyFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string privateKeyXml = File.ReadAllText(fileName);
                rsa.FromXmlString(privateKeyXml);
                return 1;
            }
            return 0;
        }
        
        public byte[] Encrypt(string plaintext)
        {
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
            RSAParameters publicKey = rsa.ExportParameters(false);
            rsa.ImportParameters(publicKey);
            byte[] ciphertext = rsa.Encrypt(plaintextBytes, true);
            return ciphertext;
        }

        public string Decrypt(byte[] ciphertext)
        {
            byte[] decrypted;
            try
            {
                decrypted = rsa.Decrypt(ciphertext, true);
            }
            catch (CryptographicException)
            {
                throw new Exception("Unable to decrypt message. Invalid private key.");
            }
            return Encoding.UTF8.GetString(decrypted);
        }

    }
}