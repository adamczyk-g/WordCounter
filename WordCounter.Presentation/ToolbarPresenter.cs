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
        private readonly IToolbarModel toolbarModel;

        public ToolbarPresenter(IToolbarView toolbarView , IToolbarModel toolbarModel)
        {
            toolbarView.ButtonOpenFileClick += ButtonOpenFileClick;
            toolbarView.ButtonRunClick += ButtonRunClick;
            //toolbarView.ButtonAboutClick += ButtonAboutClick;
            toolbarView.ButtonExitClick += ButtonExitClick;

            this.toolbarModel = toolbarModel;
        }

        private void ButtonOpenFileClick(object sender, EventArgs e)
        {
            
        }

        private void ButtonRunClick(object sender, EventArgs e)
        {
            toolbarModel.Run();
        }

        private void ButtonAboutClick(object sender, EventArgs e)
        {
            //toolbarModel.About();
        }

        private void ButtonExitClick(object sender, EventArgs e)
        {

        }
    }
}
