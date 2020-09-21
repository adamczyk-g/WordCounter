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

            MainView mainView = new MainView(toolbarView, textInputView, wordCounterView);
            MainModel mainModel = new MainModel();
            MainPresenter mainPresenter = new MainPresenter(mainView, mainModel);

            return mainPresenter;
        }
    }
}
