using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface IWordCounterView
    {
        void SetWordCounterListData(List<WordCounterListItem> listData);
    }
}
