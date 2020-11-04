using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using WordCounter.Presentation.ViewInterfaces;

namespace WordCounter.Presentation
{
    public class FileSelectionPresenter
    {
        private readonly IFileSelectionView fileOpenView;
        private readonly IFileSelectionModel fileOpenModel;

        public FileSelectionPresenter(IFileSelectionView fileOpenView, IFileSelectionModel fileOpenModel)
        {
            this.fileOpenView = fileOpenView;
            this.fileOpenModel = fileOpenModel;

            fileOpenModel.DisplayDialogRequest += OnDisplayDialogRequest;
        }        

        private void OnDisplayDialogRequest(object obj, EventArgs eventArgs)
        {
            fileOpenView.ShowView();
            if (fileOpenView.IsFileSelected)
                fileOpenModel.FilePath = fileOpenView.FilePath;
        }
    }
}
