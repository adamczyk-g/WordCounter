using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class Navigation
    {
        private readonly IWordCounterModel wordCounterModel;

        public Navigation(IToolbarView toolbarView, IWordCounterModel wordCounterModel)
        {
            toolbarView.ButtonRunClick += OnRunClick;

            this.wordCounterModel = wordCounterModel;
        }

        private void OnRunClick(object obj, EventArgs e)
        {
            wordCounterModel.
        }
    }
}
