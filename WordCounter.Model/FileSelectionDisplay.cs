using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class FileSelectionDisplay: IFileSelectionDisplay
    {
        private readonly IFileSelectionModel fileSelectionModel;

        public FileSelectionDisplay(IFileSelectionModel fileSelectionModel)
        {
            this.fileSelectionModel = fileSelectionModel;
        }

        public void Display()
        {
            fileSelectionModel.Display();
        }

        public string FilePath { get { return fileSelectionModel.FilePath; } }

    }
}
