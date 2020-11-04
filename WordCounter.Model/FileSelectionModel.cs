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
        private string filePath;

        public FileSelectionModel()
        {

        }

        public void Display()
        {
            DisplayDialogRequest.Invoke(this, EventArgs.Empty);
        }

        public string FilePath { get { return filePath; } set { filePath = value; } }

        public event EventHandler DisplayDialogRequest;
    }
}
