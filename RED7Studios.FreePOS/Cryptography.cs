using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RED7Studios.FreePOS
{
    public class Cryptography
    {
        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "Open-Source|Key|2021|Please-Do-Not-Leak-Our-Hard-Work"; // This is not the real key due to security reasons, you will not be able to use a database from a legit version.
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public static string Decrypt(string cipherText)
        {
            // Open-Source|Key|2021|Please-Do-Not-Leak-Our-Hard-Work
            string EncryptionKey = "JxfVXeG2Qmcpi6RKULYD0B3XSVDtxSiVjanhMBqu0fOr3Tvk6J3nLM1HAHxReQtE4IdbVgVKWq03eZ3Szdq1aKc530vt9daQjlgMw7cJWgBhNRtxWAH1DRJcqL7WdYXcnTLHzCnm2AbLXDrIPxVAbrXNmqIXpF6z0hoLRRZE1SKDGm9DTBd0Khpf6KXSAaT0m4KaMJzs"; // This is not the real key due to security reasons, you will not be able to use a database from a legit version.
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}