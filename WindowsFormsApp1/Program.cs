using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static bool ended = false;
        public static int timer = 60;
        public static int var;
        public static int good;
        public static int ocenka = 2;
        public static int qust_counter = 0;
        public static string curr_answ;
        public static string test_name;
        public static string[] good_ans = new string[20];
        public static string[] qsts = new string[20];
        public static string[] ans = new string[80];
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new auth());
        }
    }
}
