using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public interface IWordCounterModel
    {
        void CountWord();
        void SetText(string text);
        Dictionary<string, int> WordCounterData { get; }
        event EventHandler WordCounterDataChange;
    }
}
