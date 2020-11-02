using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using WordCounter.Presentation.ViewInterfaces;

namespace WordCounter.Presentation
{
    public class TextInputLoader
    {
        private readonly ITextInputModel textInputModel;
        private readonly IOpenFileModel fileOpenModel;

        public TextInputLoader(ITextInputModel textInputModel, IOpenFileModel fileOpenModel)
        {
            this.textInputModel = textInputModel;
            this.fileOpenModel = fileOpenModel;

            fileOpenModel.FileWasLoaded += OnFileLoaded;
        }

        private void OnFileLoaded(object obj, EventArgs eventArgs)
        {
            textInputModel.Text = fileOpenModel.FileContent;
        }
    }
}
