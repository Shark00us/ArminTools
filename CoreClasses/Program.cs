/*
 * User: Armin
 * Date: 11/21/2023
 * Time: 08:39 ب.ظ
 */
using System;
using System.Windows.Forms;

namespace ArminTools
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal static class Program
    {
        private static readonly ILanguage AppLang;
        public static ILanguage ApplicationLanguage { get { return AppLang; } }


        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static Program()
        {
            AppLang = new Persian();
        }

    }
}
