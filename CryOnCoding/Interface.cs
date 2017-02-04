using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryOnCoding
{
    class Interface
    {
        public static void Send()
        {
            Utils.EncryptMessage(Program.mWindow.textBoxMessage.Text);
        }

        public static void Decrypt()
        {
            Utils.DecryptMessage(Program.mWindow.textBoxMessage.Text);
        }

        public static void MasterKeyUpdate()
        {
            COClib.COC.SetKey(Program.mWindow.textBoxKey.Text);
            Console.WriteLine(Convert.ToBase64String(COClib.COC.masterKey));
        }

        public static void GenerateKey()
        {
            COClib.COC.GenKey();
            Program.mWindow.textBoxKey.Text = Encoding.ASCII.GetString(COClib.COC.masterKey);
        }
    }
}
