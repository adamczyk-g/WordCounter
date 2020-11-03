using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface IOpenFileView
    {
        void ShowView();
        void ShowMessageBox(string message);
        bool Result { get; }
        string FilePath { get; }
    }
}
