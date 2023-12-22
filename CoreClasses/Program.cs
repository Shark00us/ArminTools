using ArminTools.FormClasses;
using ArminTools.SubClasses.Languages;
using System;
using System.Windows.Forms;

namespace ArminTools.CoreClasses
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal static class Program
    {
        public static ILanguage ApplicationLanguage { get; }


        [STAThread]
        private static void Main(string[] args)
        {
            if (ApplicationLanguage != null)
            {
                Application.Run(new MainForm());
            }

        }
        static Program()
        {
            ILanguage[] languages =
            {
                new English(),
                new Persian()
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (SelectConfigForm myForm = new SelectConfigForm(languages))
            {
                if (myForm.ShowDialog() == DialogResult.OK)
                {
                    ApplicationLanguage = myForm.SelectedLanguage;
                }
            }

        }

    }
}
