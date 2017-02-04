using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryOnCoding
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
    
        // Ссылка на главное окно
        public static MWindow mWindow;
        public static bool autoEncrypt;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mWindow = new MWindow());
        }
    }
}
