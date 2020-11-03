using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCounter.Model
{
    public class LoadTextFromFile
    {
        public LoadTextFromFile() { }

        public void Load()
        {
            //pobierz ścieżkę pliku od użytkownika
            //spróbuj otworzyć plik
            //spróbuj przeczytać plik
            //zwróć zawartość

            //wyświetl błędy
            //zaloguj błędy
        }

        private void ReadFileContent(string filePath)
        {
            FileNameRequest.Invoke(this, EventArgs.Empty);

            try
            {
                FileContent = File.ReadAllText(filePath);

                FileWasLoaded?.Invoke(this, EventArgs.Empty);
            }

            catch (Exception e) { OpenFileError.Invoke(e.Message, new OpenFileErrorEventArgs(e.Message)); };

        }

        public string FileContent { get; private set; }
    }
}
