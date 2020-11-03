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
        private readonly IOpenFileModel openFileModel;

        public TextInputModel(IOpenFileModel openFileModel)
        {
            text = string.Empty;
            this.openFileModel = openFileModel;
        }

        public string Text { get { return text; } set { text = value; TextInputDataChange?.Invoke(this, EventArgs.Empty); } }

        public void LoadTextFromFile()
        {
            //pobierz ścieżkę pliku od użytkownika
            openFileModel.ReadFileContent();
            //spróbuj otworzyć plik
            //spróbuj przeczytać plik
            //zwróć zawartość
        }

        public event EventHandler TextInputDataChange;
    }
}
