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
        public static byte[] masterKey;


        // Генератор ключа
        public static void GenKey()
        {
            // TODO: Генерация ключа
            masterKey = Encoding.ASCII.GetBytes("test00101001");
        }

        // Установка ключа
        public static bool SetKey(string key)
        {
            masterKey = Encoding.ASCII.GetBytes(key);
            return true;
        }

        // Шифровка
        public static string Encrypt(string message)
        {
            string encrypted = CryptMaster.Encrypt(message, Convert.ToBase64String(masterKey));
            return encrypted;
        }

        // Расшифровка
        public static string Decrypt(string message)
        {
            string decrypted;
            try
            {
                decrypted = CryptMaster.Decrypt(message, Convert.ToBase64String(masterKey));
            } catch (Exception e)
            {
                return "Decryption error";
            }
            return decrypted;
        }
    }
}
