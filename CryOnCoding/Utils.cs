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
        public static bool SendMessage (string message)
        {
            message = "[COC]" + COClib.COC.Encrypt(message);
            return true; // TO DO
        }

        public static void PrintMyMessage(string message)
        {
            message = "Вы: " + message;
            Program.mainWindow.textBoxChat.AppendText(message + Environment.NewLine);
        }
    }
}
