using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using System.IO;

namespace WordCounter.Model
{
    public class FileSelectionModel : IFileSelectionModel
    {
        private IModalDialogBuilder modalDialogBuilder;
        private string filePath;

        public FileSelectionModel(IModalDialogBuilder modalDialogBuilder)
        {
            this.modalDialogBuilder = modalDialogBuilder;
        }



        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
        }

        public string FileContent { get; private set; }

        public event EventHandler FileWasLoaded;
        public event EventHandler OpenFileError;
        public event EventHandler FileNameRequest;
    }
}
