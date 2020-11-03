using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface IFileSelectionView
    {
        void ShowView();
        void ShowMessageBox(string message);
        bool IsFileSelected { get; }
        string FilePath { get; }
    }
}
