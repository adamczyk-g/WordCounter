using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
   public class WordCounterPresenter
   {
        private readonly IWordCounterView wordCounterView;
        private readonly IWordCounterModel wordCounterModel;

        public WordCounterPresenter(IWordCounterView wordCounterView, IWordCounterModel wordCounterModel)
        {
            this.wordCounterView = wordCounterView;
            this.wordCounterModel = wordCounterModel;
            wordCounterModel.WordCounterDataChange += OnModelDataCHange;
        }

        private void OnModelDataCHange(object obj, EventArgs e)
        {
            wordCounterView.SetWordCounterListData(wordCounterModel.WordCounterData.Select(x => new WordCounterListItem() { Word = x.Key, Count = x.Value }).ToList());
        }
    }
}
