using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public interface IFileSelectionModel
    {
        //void ReadFileContent();
        //event EventHandler FileWasLoaded;
        //string FileContent { get; }
        //event EventHandler OpenFileError;
        event EventHandler FileNameRequest;
        void SetFilePath(string filePath);
    }
}
