using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class AboutButtonNavigator
    {
        private readonly IAboutView aboutView;

        public AboutButtonNavigator(IToolbarView toolbarView, IAboutView aboutView)
        {
            toolbarView.ButtonAboutClick += OnAboutClick;

            this.aboutView = aboutView;
        }

        private void OnAboutClick(object obj, EventArgs e)
        {
            aboutView.ShowView();
        }
    }
}
