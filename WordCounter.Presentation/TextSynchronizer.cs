using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class TextSynchronizer
    {
        private readonly IWordCounterModel wordCounterModel;
        private readonly ITextInputModel textInputModel;

        public TextSynchronizer(IWordCounterModel wordCounterModel, ITextInputModel textInputModel)
        {
            this.wordCounterModel = wordCounterModel;
            this.textInputModel = textInputModel;

            textInputModel.TextInputChange += OnTextInputChange;
        }

        private void OnTextInputChange(object obj, EventArgs e)
        {
            wordCounterModel.SetText(textInputModel.Text);
        }
    }
}
