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
        public static string MessageGen (string message)
        {
            message = "[COC]" + COClib.COC.Encrypt(message);
            return message;
        }
        public static void SendMessage (string message)
        {

        }
    }
}
