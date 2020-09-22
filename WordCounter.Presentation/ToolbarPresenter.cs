using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class ToolbarPresenter
    {
        public ToolbarPresenter(IToolbarView toolbarView , IToolbarModel toolbarModel)
        {
            toolbarView.ButtonOpenFileClick += ButtonOpenFileClick;
            toolbarView.ButtonRunClick += ButtonRunClick;
            toolbarView.ButtonInfoClick += ButtonInfoClick;
            toolbarView.ButtonExitClick += ButtonExitClick;
        }

        private void ButtonOpenFileClick(object sender, EventArgs e)
        {
            toolbarModel.OpenFile();
        }

        private void ButtonRunClick(object sender, EventArgs e)
        {

        }

        private void ButtonInfoClick(object sender, EventArgs e)
        {

        }

        private void ButtonExitClick(object sender, EventArgs e)
        {

        }
    }
}
