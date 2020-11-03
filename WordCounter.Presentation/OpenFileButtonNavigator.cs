using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class OpenFileButtonNavigator
    {
        private readonly ITextInputModel textInputModel;

        public OpenFileButtonNavigator(IToolbarView toolbarView, ITextInputModel textInputModel)
        {
            toolbarView.ButtonOpenFileClick += OnOpenFileClick;

            this.textInputModel = textInputModel;
        }

        private void OnOpenFileClick(object obj, EventArgs e)
        {
            textInputModel.LoadTextFromFile();
        }
    }
}
