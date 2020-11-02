using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using System.IO;

namespace WordCounter.Model
{
    public class OpenFileModel: IOpenFileModel
    {
        private string filePath;

        public OpenFileModel()
        {

        }

        public void ReadFileContent(string filePath)
        {

            FileContent = File.ReadAllText(filePath);

            FileWasLoaded?.Invoke(this, EventArgs.Empty);
        }

        public string FileContent { get; private set; }

        //public event EventHandler FileNameRequest;
        public event EventHandler FileWasLoaded;
    }
}
