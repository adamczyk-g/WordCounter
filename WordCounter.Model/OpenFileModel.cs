using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using System.IO;

namespace WordCounter.Model
{
    public class OpenFileModel : IOpenFileModel
    {

        private IModalDialogBuilder modalDialogBuilder;
        private string filePath;

        public OpenFileModel(IModalDialogBuilder modalDialogBuilder)
        {
            this.modalDialogBuilder = modalDialogBuilder;
        }

        public void ReadFileContent()
        {
            FileNameRequest.Invoke(this, EventArgs.Empty);

            try
            {
                FileContent = File.ReadAllText(filePath);

                FileWasLoaded?.Invoke(this, EventArgs.Empty);
            }

            catch (Exception e) { OpenFileError.Invoke(e.Message, new OpenFileErrorEventArgs(e.Message)); };

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
