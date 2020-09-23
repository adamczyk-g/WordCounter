using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class TextInputPresenter
    {
        private ITextInputView textInputView;
        private ITextInputModel textInputModel;

        public TextInputPresenter(ITextInputView textInputView, ITextInputModel textInputModel)
        {
            this.textInputView = textInputView;
            this.textInputModel = textInputModel;

            textInputView.TextInputChanged += OnTextChanged;
        }

        private void OnTextChanged(object obj, EventArgs e)
        {
            textInputModel.Text = textInputView.GetText();
        }


    }
}
