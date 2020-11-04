using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class LoadTextFromFile: ILoadTextFromFile
    {
        private readonly IFileSelectionDisplay fileSelectionDisplay;

        public LoadTextFromFile(IFileSelectionDisplay fileSelectionDisplay)
        {
            this.fileSelectionDisplay = fileSelectionDisplay;
        }

        public void Load()
        {
            fileSelectionDisplay.Display();
            string filePath = fileSelectionDisplay.FilePath;
            ReadFileContent(filePath);

            //wyświetl błędy
            //zaloguj błędy
        }

        private void ReadFileContent(string filePath)
        {            
            try
            {
                FileContent = File.ReadAllText(filePath);
            }

            catch (Exception e)
            {

            };
            
        }

        public string FileContent { get; private set; }
    }
}
