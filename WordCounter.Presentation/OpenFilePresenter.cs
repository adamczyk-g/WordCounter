using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using WordCounter.Presentation.ViewInterfaces;

namespace WordCounter.Presentation
{
    public class OpenFilePresenter
    {
        private readonly IOpenFileView fileOpenView;
        private readonly IOpenFileModel fileOpenModel;

        public OpenFilePresenter(IOpenFileView fileOpenView, IOpenFileModel fileOpenModel)
        {
            this.fileOpenView = fileOpenView;
            this.fileOpenModel = fileOpenModel;

            fileOpenModel.OpenFileError += OnOpenFileError;
            fileOpenModel.FileNameRequest += OnFileNameRequest;
        }

        private void OnOpenFileError(object obj, EventArgs eventArgs)
        {
            fileOpenView.ShowMessageBox(((OpenFileErrorEventArgs)eventArgs).Message);
        }

        private void OnFileNameRequest(object obj, EventArgs eventArgs)
        {
            fileOpenView.ShowView();
            if (fileOpenView.Result)
                fileOpenModel.SetFilePath(fileOpenView.FilePath);
        }
    }

}
