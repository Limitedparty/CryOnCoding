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
            string usermessage = Program.mainWindow.textBoxInput.Text;
            Utils.SendMessage(usermessage);
            Utils.PrintMyMessage(usermessage);
        }

        public static void MasterKeyUpdate()
        {
            COClib.COC.SetKey(Program.mainWindow.textBoxMasterKey.Text);
            Console.WriteLine(Convert.ToBase64String(COClib.COC.masterKey));
        }

        public static void GenerateKey()
        {
            COClib.COC.GenKey();
            Program.mainWindow.textBoxMasterKey.Text = Encoding.ASCII.GetString(COClib.COC.masterKey);
        }

        public static void Update()
        {

        }
    }
}
