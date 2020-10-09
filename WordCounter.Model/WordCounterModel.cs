using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class WordCounterModel: IWordCounterModel
    {
        private readonly WordFrequencyCounter wordCounter;
        private Dictionary<string, int> wordCounterData;
        private string text;

        public WordCounterModel(WordFrequencyCounter wordCounter)
        {
            this.wordCounter = wordCounter;
            wordCounterData = new Dictionary<string, int>();
            text = string.Empty;
        }

        public void CountWord()
        {            
            WordCounterData = wordCounter.CountFrequency(text);
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public Dictionary<string, int> WordCounterData { get { return wordCounterData; } private set { wordCounterData = value;  WordCounterDataChange.Invoke(this, EventArgs.Empty); } }

        public event EventHandler WordCounterDataChange;
    }
}
