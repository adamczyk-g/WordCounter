using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WordCounter.WinFormsClient.Views;
using WordCounter.Presentation;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model;
using WordCounter.Model.ModelInterfaces;

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
            //ToolbarPresenter toolbarPresenter = new ToolbarPresenter(toolbarView, toolbarModel);
            
            IModalDialogBuilder modalDialogBuilder = new ModalDialogBuilder();

            FileSelectionView fileSelectionView = new FileSelectionView();
            IFileSelectionView fileSelectionViewPure = new FileSelectionViewPure();
            FileSelectionModel fileSelectionModel = new FileSelectionModel();
            FileSelectionPresenter openFilePresenter = new FileSelectionPresenter(fileSelectionView, fileSelectionModel);

            TextInputModel textInputModel = new TextInputModel(fileSelectionModel);
            TextInputPresenter textInputPresenter = new TextInputPresenter(textInputView, textInputModel);

            WordFrequencyCounter wordFrequencyCounter= new WordFrequencyCounter();
            WordCounterModel wordCounterModel = new WordCounterModel(wordFrequencyCounter);
            WordCounterPresenter wordCounterPresenter = new WordCounterPresenter(wordCounterView, wordCounterModel);

            RunButtonNavigator runButtonNavigator = new RunButtonNavigator(toolbarView, wordCounterModel);

            MainView mainView = new MainView(toolbarView, textInputView, wordCounterView, statusBarView);
            MainModel mainModel = new MainModel();
            MainPresenter mainPresenter = new MainPresenter(mainView, mainModel);

            AboutView aboutView = new AboutView();
            AboutModel aboutModel = new AboutModel();
            AboutPresenter aboutPresenter = new AboutPresenter(aboutView, aboutModel);

            RunButtonNavigator navigation = new RunButtonNavigator(toolbarView, wordCounterModel);
            AboutButtonNavigator aboutButtonNavigator = new AboutButtonNavigator(toolbarView, aboutView);
            TextSynchronizer modelConnector = new TextSynchronizer(wordCounterModel, textInputModel);

            IFileSelectionDisplay fileSelectionDisplay = new FileSelectionDisplay(fileSelectionModel);

            ILoadTextFromFile loadTextFromFile = new LoadTextFromFile(fileSelectionDisplay);
            LoadTextFromFileToTextInput loadTextFromFileToTextInput = new LoadTextFromFileToTextInput(loadTextFromFile, textInputModel);
            FileSelectionNavigator openFileButtonNavigator = new FileSelectionNavigator(toolbarView, loadTextFromFileToTextInput);

            TextInputLoader textInputLoader = new TextInputLoader(textInputModel, fileSelectionModel);

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
