using System;
using System.Windows.Forms;

namespace WordCounter.WinFormsClient
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            CompositionRoot compositionRoot = new CompositionRoot();
            Application.Run((Form)compositionRoot.CreateMainPresenter().GetMainView());
        }
    }
}
