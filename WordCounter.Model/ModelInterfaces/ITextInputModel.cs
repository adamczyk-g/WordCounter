using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public interface ITextInputModel
    {
        event EventHandler TextInputChange;
        string Text { get; set; }
    }
}
