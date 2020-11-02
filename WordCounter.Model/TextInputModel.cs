using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class TextInputModel: ITextInputModel
    {
        private string text;

        public TextInputModel()
        {
            text = string.Empty;
        }

        public string Text { get { return text; }
            set { text = value; TextInputDataChange?.Invoke(this, EventArgs.Empty); } }

        public event EventHandler TextInputDataChange;
    }
}
