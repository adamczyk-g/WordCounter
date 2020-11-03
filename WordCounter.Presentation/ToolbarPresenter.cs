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
            toolbarView.ButtonRunClick += ButtonRunClick;

            this.toolbarModel = toolbarModel;
        }

        private void ButtonRunClick(object sender, EventArgs e)
        {
            toolbarModel.Run();
        }
    }
}
