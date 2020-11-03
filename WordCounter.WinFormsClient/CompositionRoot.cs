using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WordCounter.WinFormsClient.Views;
using WordCounter.Presentation;
using WordCounter.Model;

namespace WordCounter.WinFormsClient
{
    public class CompositionRoot
    {
        public CompositionRoot()
        {

        }

        public MainPresenter CreateMainPresenter()
        {
            ToolbarView toolbarView = new ToolbarView();
            TextInputView textInputView = new TextInputView();
            WordCounterView wordCounterView = new WordCounterView();
            StatusBarView statusBarView = new StatusBarView();

            ToolbarModel toolbarModel = new ToolbarModel();
            ToolbarPresenter toolbarPresenter = new ToolbarPresenter(toolbarView, toolbarModel);

            IModalDialogBuilder modalDialogBuilder = new ModalDialogBuilder();

            OpenFileView openFileView = new OpenFileView();
            OpenFileModel openFileModel = new OpenFileModel(modalDialogBuilder);
            OpenFilePresenter openFilePresenter = new OpenFilePresenter(openFileView, openFileModel);

            TextInputModel textInputModel = new TextInputModel(openFileModel);
            TextInputPresenter textInputPresenter = new TextInputPresenter(textInputView, textInputModel);

            WordFrequencyCounter wordFrequencyCounter= new WordFrequencyCounter();
            WordCounterModel wordCounterModel = new WordCounterModel(wordFrequencyCounter);
            WordCounterPresenter wordCounterPresenter = new WordCounterPresenter(wordCounterView, wordCounterModel);

            MainView mainView = new MainView(toolbarView, textInputView, wordCounterView, statusBarView);
            MainModel mainModel = new MainModel();
            MainPresenter mainPresenter = new MainPresenter(mainView, mainModel);

            AboutView aboutView = new AboutView();
            AboutModel aboutModel = new AboutModel();
            AboutPresenter aboutPresenter = new AboutPresenter(aboutView, aboutModel);

            RunButtonNavigator navigation = new RunButtonNavigator(toolbarView, wordCounterModel);
            AboutButtonNavigator aboutButtonNavigator = new AboutButtonNavigator(toolbarView, aboutView);
            ModelConnector modelConnector = new ModelConnector(toolbarModel, wordCounterModel, textInputModel);
                       

            OpenFileButtonNavigator openFileButtonNavigator = new OpenFileButtonNavigator(toolbarView, textInputModel);

            TextInputLoader textInputLoader = new TextInputLoader(textInputModel, openFileModel);

            /*
             * Użytkownik chce załadowac nowy plik do okna wyświetlającego tekst ksiązki
             * Naciska przycisk
             * Pojawia sie okno wyboru pliku
             * uzytkownik wybiera plik
             * 
             * okno zwraca ścieżkę pliku
             * ścieżka jest przekazywana do ...
             * ... otwiera plik i czyta zawartość za pomocą pasującego readera
             * ... generuje zdarzenie załadowano nowy plik
             * 
             * okno treści wczytuje nowy plik i generuje zdarzenie że plik został wczytany
             * 
             * zawartośc pliku jest ładowana do okna treści
             */

            return mainPresenter;
        }
    }
}
