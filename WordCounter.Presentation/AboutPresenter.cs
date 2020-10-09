using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;
using WordCounter.Presentation.ViewInterfaces;

namespace WordCounter.Presentation
{
    public class AboutPresenter
    {
        private readonly IAboutView aboutView;
        private readonly IAboutModel aboutModel;

        public AboutPresenter(IAboutView aboutView, IAboutModel aboutModel)
        {
            this.aboutView = aboutView;
            this.aboutModel = aboutModel;

            this.aboutView.ViewLoad += OnViewLoad;
        }

        private void OnViewLoad(object obje, EventArgs e)
        {
            aboutView.SetAboutText(aboutModel.AboutText);
        }
    }
}
