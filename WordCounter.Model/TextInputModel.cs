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
        private readonly IFileSelectionModel openFileModel;

        public TextInputModel(IFileSelectionModel openFileModel)
        {
            text = string.Empty;
            this.openFileModel = openFileModel;
        }

        public string Text { get { return text; } set { text = value; TextInputChange?.Invoke(this, EventArgs.Empty); } }

        public event EventHandler TextInputChange;
    }
}
