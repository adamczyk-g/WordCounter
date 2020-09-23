using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public class WordCounterListItem
    {
        public WordCounterListItem() { }
        public WordCounterListItem(string word, int count)
        {
            Word = word;
            Count = count;
        }
        public string Word { get; set; }
        public int Count { get; set; }
    }
}
