using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface ITextInputView
    {
        string GetText();
        event EventHandler TextInputChanged;
        string Text { get; set; }
    }
}
