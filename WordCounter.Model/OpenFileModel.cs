using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class OpenFileModel: IOpenFileModel
    {
        private string filePath;

        public OpenFileModel()
        {

        }

        public void AskUserForFilePath()
        {
            throw new NotImplementedException();
        }

        public string FileContent { get; }

        public event EventHandler NewFileWasLoaded;
    }
}
