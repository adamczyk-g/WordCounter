using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class MainPresenter
    {
        private readonly IMainView mainView;

        public MainPresenter(IMainView mainView, IMainModel mainModel)
        {
            this.mainView = mainView;


        }

        public IMainView GetMainView() => mainView;
    }
}
