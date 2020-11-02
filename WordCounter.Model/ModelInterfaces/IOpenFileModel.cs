using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public interface IOpenFileModel
    {
        void ReadFileContent(string filePath);
        event EventHandler FileWasLoaded;
        string FileContent { get; }
    }
}
