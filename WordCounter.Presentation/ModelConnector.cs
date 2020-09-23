using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class ModelConnector
    {
        private readonly IWordCounterModel wordCounterModel;
        private readonly ITextInputModel textInputModel;

        public ModelConnector(IToolbarModel toolbarModel, IWordCounterModel wordCounterModel, ITextInputModel textInputModel)
        {
            this.wordCounterModel = wordCounterModel;
            this.textInputModel = textInputModel;

            toolbarModel.ButtonRunClick += OnRunButton;
        }

        private void OnRunButton(object obj, EventArgs e)
        {
            wordCounterModel.SetText(textInputModel.Text);

        }
    }
}
