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

            textInputView.TextInputChanged += OnViewTextChanged;
            textInputModel.TextInputDataChange += OnModelTextChanged;
        }

        private void OnViewTextChanged(object obj, EventArgs e)
        {
            if (textInputView.Text != textInputModel.Text)
                textInputModel.Text = textInputView.Text;
        }

        private void OnModelTextChanged(object obj, EventArgs e)
        {
            if(textInputView.Text != textInputModel.Text)
                textInputView.Text = textInputModel.Text;
        }

    }
}
