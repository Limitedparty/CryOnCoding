using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace COClib
{
    public class COC
    {
        public static Aes masterKey;


        // Генератор ключа
        public static void GenKey()
        {
            masterKey = Aes.Create();
        }

        // Шифровка
        public static String Encrypt()
        {
            byte[] encrypted = CryptMaster.EncryptStringToBytesAes(original, myAes.Key, myAes.IV);
            return "";
        }

        // Расшифровка
        public static String Decrypt()
        {
            return "";
        }
    }
}
