using System;
using System.Windows.Forms;
using WordCounter.WinFormsClient.Views;

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

            ToolbarView toolbarView = new ToolbarView();
            TextInputView textInputView = new TextInputView();
            WordCounterView wordCounterView = new WordCounterView();

            Application.Run(new MainView(toolbarView, textInputView, wordCounterView));


        }
    }
}
