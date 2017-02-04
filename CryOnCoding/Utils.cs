using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COClib;

namespace CryOnCoding
{
    class Utils
    {
        public static bool EncryptMessage (string message)
        {
            try
            {
                message = COClib.COC.Encrypt(message);
                PrintMessage(message);
                return true;
            }
            catch (Exception e)
            {
                return false; // TO DO
            }
        }

        public static bool DecryptMessage(string message)
        {
            try
            {
                message = COClib.COC.Decrypt(message);
                PrintMessage(message);
                return true;
            }
            catch (Exception e)
            {
                return false; // TO DO
            }
        }

        public static void PrintMessage(string message)
        {
            Program.mWindow.textBoxEncrypted.Text = message;
        }
    }
}
