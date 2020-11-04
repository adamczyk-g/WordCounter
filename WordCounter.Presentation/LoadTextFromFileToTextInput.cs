using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class LoadTextFromFileToTextInput
    {
        private readonly ILoadTextFromFile loadTextFromFile;
        private readonly ITextInputModel textInputModel;

        public LoadTextFromFileToTextInput(ILoadTextFromFile loadTextFromFile, ITextInputModel textInputModel)
        {
            this.loadTextFromFile = loadTextFromFile;
            this.textInputModel = textInputModel;
        }

        public void Load()
        {
            loadTextFromFile.Load();
            textInputModel.Text = loadTextFromFile.FileContent;
        }
    }
}
