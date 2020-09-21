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

            TextInputModel textInputModel = new TextInputModel();
            TextInputPresenter textInputPresenter = new TextInputPresenter(textInputView, textInputModel);

            WordCounterModel wordCounterModel = new WordCounterModel();
            WordCounterPresenter wordCounterPresenter = new WordCounterPresenter(wordCounterView, wordCounterModel);

            MainView mainView = new MainView(toolbarView, textInputView, wordCounterView, statusBarView);
            MainModel mainModel = new MainModel();
            MainPresenter mainPresenter = new MainPresenter(mainView, mainModel);

            return mainPresenter;
        }
    }
}
