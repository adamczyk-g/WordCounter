using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class FileSelectionNavigator
    {
        LoadTextFromFileToTextInput loadTextFromFileToTextInput;

        public FileSelectionNavigator(IToolbarView toolbarView, LoadTextFromFileToTextInput loadTextFromFileToTextInput)
        {
            toolbarView.ButtonOpenFileClick += OnOpenFileClick;
            this.loadTextFromFileToTextInput = loadTextFromFileToTextInput;
        }

        private void OnOpenFileClick(object obj, EventArgs e)
        {
            loadTextFromFileToTextInput.Load();
        }
    }
}
