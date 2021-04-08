using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace Hakediş
{
  public static class CryptoEngine 
    {
        public static string Encrypt(string Text)
        {
            var publicKey = File.ReadAllText("decrypt.xml");
            // RSA Public Key'i buraya yazmalısınız.
            // Yukarıda verdiğim linkte görebilirsiniz.
            var testData = Encoding.UTF8.GetBytes(Text);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(publicKey.ToString());
                    var encryptedData = rsa.Encrypt(testData, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }

        }
        public static string Decrypt(string Text)
        {
            string BOS = "";
            try
            {
                var privateKey = File.ReadAllText("encrypt.xml");
                // buraya gizli key'inizi yazmalısınız.
                var testData = Encoding.UTF8.GetBytes(Text);
                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    try
                    {
                        var base64Encrypted = Text;
                        rsa.FromXmlString(privateKey);
                        var resultBytes = Convert.FromBase64String(base64Encrypted);
                        var decryptedBytes = rsa.Decrypt(resultBytes, true);
                        var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                        return decryptedData.ToString();
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }
                }
            }
            catch { return BOS; } // şifre çözülemedi ise "BOS" cevabı dönecek
        }
    }
}
